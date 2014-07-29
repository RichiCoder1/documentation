using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Compiler.Models;
using Compiler.Properties;
using Docu;
using Docu.Documentation;
using Veil;

namespace Compiler
{
    public class Program
    {
        public static int Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine(@"Usage: ApiDocGenerator.exe <root> <output-file>");
                return 1;
            }

            // Get the content model.
            Console.WriteLine("Getting document model...");
            var documentModel = GetDocumentModel(args[0]);
            if (documentModel == null)
            {
                Console.WriteLine(@"Could not get document model.");
                return 1;
            }

            // Generate the documentation.
            Console.WriteLine("Generating content...");
            var model = ContentModelGenerator.Generate(documentModel);
            var result = Generate(model);

            if (args.Length == 2)
            {
                // Create output directory.
                var outputFile = Path.GetFullPath(args[1]);
                var outputDirectory = Path.GetDirectoryName(outputFile);
                Debug.Assert(outputDirectory != null);
                if (!Directory.Exists(outputDirectory))
                {
                    Console.WriteLine("Creating output directory...");
                    Directory.CreateDirectory(outputDirectory);
                }

                // Write the documentation to disk.
                Console.WriteLine("Writing to {0}...", outputFile);
                using (var stream = File.OpenWrite(outputFile))
                using (var writer = new StreamWriter(stream))
                {
                    writer.Write(result);
                }
            }

            return 0;
        }

        private static string Generate(ContentModel model)
        {
            var engine = new VeilEngine();
            var template = engine.Compile<ContentModel>("handlebars", new StringReader(Resources.Template));
            using (var writer = new StringWriter())
            {
                template(writer, model);
                return RemoveEmptyLines(writer.ToString());
            }
        }

        private static string RemoveEmptyLines(string result)
        {
            var previousWasEmptyLine = false;
            var builder = new StringBuilder();
            foreach (var line in result.SplitByNewLine())
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    previousWasEmptyLine = true;
                }
                else
                {
                    if (previousWasEmptyLine)
                    {
                        builder.AppendLine();
                        previousWasEmptyLine = false;
                    }
                    builder.AppendLine(line);
                }
            }
            return builder.ToString();
        }

        private static List<string> GetFiles(string root)
        {
            root = Path.GetFullPath(root);

            var paths = new List<string>
            {
                Path.Combine(root, "Cake.Common.dll"),
                Path.Combine(root, "Cake.Common.xml"),
                Path.Combine(root, "Cake.Core.dll")
            };

            foreach (var path in paths)
            {
                if (!File.Exists(path))
                {
                    Console.WriteLine(@"Could not find '{0}'.", path);
                    return null;
                }
            }

            return paths;
        }

        private static IList<Namespace> GetDocumentModel(string root)
        {
            var files = GetFiles(root);
            var assemblies = GetAssemblies(files).ToList();
            var xml = GetFilesWithExtension(files, "xml");
            var provider = new DocumentModelProvider();
            return provider.GetDocumentModel(assemblies, xml);
        }

        private static IEnumerable<Assembly> GetAssemblies(List<string> files)
        {
            foreach (var file in GetFilesWithExtension(files, "dll"))
            {
                yield return Assembly.LoadFile(file);
            }
        }

        private static IEnumerable<string> GetFilesWithExtension(IEnumerable<string> files, string extension)
        {
            var result = new List<string>();
            foreach (var file in files)
            {
                if (file.EndsWith(extension, StringComparison.InvariantCultureIgnoreCase))
                {
                    result.Add(file);
                }
            }
            return result;
        }
    }
}

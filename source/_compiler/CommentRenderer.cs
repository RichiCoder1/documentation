using System;
using System.IO;
using Docu.Documentation.Comments;

namespace Compiler
{
    public static class CommentRenderer
    {
        public static string Render(IComment comment)
        {
            using (var writer = new StringWriter())
            {
                Render(comment, writer);
                return writer.ToString();
            }
        }

        private static void Render(IComment node, TextWriter writer)
        {
            if (node is Summary)
            {
                foreach (var child in node.Children)
                {
                    Render(child, writer);
                }
            }
            else if (node is InlineText)
            {
                RenderText((InlineText)node, writer);
            }
            else if (node is ParameterReference)
            {
                RenderParameterReference((ParameterReference)node, writer);
            }
            else
            {
                throw new NotSupportedException();
            }
        }

        private static void RenderText(InlineText node, TextWriter writer)
        {
            writer.Write(node.Text);
        }

        private static void RenderParameterReference(ParameterReference node, TextWriter writer)
        {
            writer.Write(string.Concat("**", node.Parameter, "**"));
        }
    }
}

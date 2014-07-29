using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Cake.Core.Annotations;
using Compiler.Extensions;
using Compiler.Models;
using Docu.Documentation;

namespace Compiler
{
    public static class ContentModelGenerator
    {
        public static ContentModel Generate(IList<Namespace> model)
        {
            var data = GetMethods(model);

            var result = new ContentModel();
            result.Categories = new List<CategoryModel>();

            foreach (var categoryName in data.Keys.OrderBy(x => x))
            {
                var category = new CategoryModel();
                category.Name = categoryName;
                category.Categories = new List<SubCategoryModel>();

                foreach (var subCategoryName in data[categoryName].Keys)
                {
                    var subCategory = new SubCategoryModel();
                    subCategory.Name = subCategoryName;
                    subCategory.Methods = new List<MethodModel>();

                    foreach (var method in data[categoryName][subCategoryName])
                    {
                        var aliasMethod = new MethodModel();
                        aliasMethod.Name = method.RepresentedMethod.GetMethodSignature();
                        aliasMethod.Description = CommentRenderer.Render(method.Summary);

                        subCategory.Methods.Add(aliasMethod);
                    }

                    category.Categories.Add(subCategory);
                }

                result.Categories.Add(category);
            }

            return result;
        }

        private static Dictionary<string, Dictionary<string, List<Method>>> GetMethods(IList<Namespace> model)
        {
            var result = new Dictionary<string, Dictionary<string, List<Method>>>();

            foreach (var ns in model)
            {
                foreach (var type in ns.Types)
                {
                    foreach (var method in type.Methods)
                    {
                        if (method.RepresentedMethod.IsDefined(typeof(CakeAliasAttribute)))
                        {
                            var typeCategory = method.Type.RepresentedType.GetCustomAttribute<CakeAliasCategoryAttribute>();
                            var methodCategory = method.RepresentedMethod.GetCustomAttribute<CakeAliasCategoryAttribute>();

                            var parentCategory = typeCategory != null ? typeCategory.Name : "Misc";
                            var category = methodCategory != null ? methodCategory.Name : "";

                            if (!result.ContainsKey(parentCategory))
                            {
                                result.Add(parentCategory, new Dictionary<string, List<Method>>());
                            }
                            if (!result[parentCategory].ContainsKey(category))
                            {
                                result[parentCategory].Add(category, new List<Method>());
                            }
                            result[parentCategory][category].Add(method);
                        }
                    }
                }
            }

            return result;
        }
    }
}

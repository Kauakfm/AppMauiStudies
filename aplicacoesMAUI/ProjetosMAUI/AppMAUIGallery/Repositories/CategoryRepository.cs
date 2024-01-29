using AppMAUIGallery.Models;
using AppMAUIGallery.Views;
using AppMAUIGallery.Views.Layouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMAUIGallery.Repositories
{
    internal class CategoryRepository
    {
        public CategoryRepository() { }

        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            categories.Add(new Category
            {
                Name = "Layout",
                Components = new List<Components> {
                    new Components {
                    Title = "StackLayout",
                    Description = "Organização sequencial dos elementos.",
                    Page = typeof(StackLayoutPage)
                    } ,
                    new Components
                    {
                        Title = "Grid",
                        Description = "Organiza os elementos dentro de uma tabela.",
                        Page = typeof(GridLayoutPage)
                    },
                    new Components
                    {
                        Title = "AbsoluteLayout",
                        Description = "Liberdade total para posicionar e dimensionar os elementos na tela.",
                        Page = typeof(AbsoluteLayoutPage)
                    }
                }
            });
            return categories;
        }
    }
}

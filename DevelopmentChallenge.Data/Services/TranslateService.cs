using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Services
{
    public static class TranslateService
    {
        private static readonly Dictionary<int, Dictionary<string, string>> Translations = new Dictionary<int, Dictionary<string, string>>
        {
            {
            1,
                new Dictionary<string, string>
                {
#region shapes
                    { "Square", "Square"},
                    { "Squares", "Squares"},
                    { "Circle", "Circle"},
                    { "Circles", "Circles"},
                    { "Triangle", "Triangle"},
                    { "Triangles", "Triangles"},
                    #endregion
#region messages
                    { "EmptyList", "<h1>Empty list of shapes!</h1>"},
                    { "ReportTitle", "<h1>Shape Report</h1>"}
#endregion
                }

            },
            {
            2,
                new Dictionary<string, string>
                {
#region shapes
                    { "Square", "Cuadrado"},
                    { "Squares", "Squares"},
                    { "Circle", "Circle"},
                    { "Circles", "Circles"},
                    { "Triangle", "Triangle"},
                    { "Triangles", "Triangles"},
#endregion
#region messages
                    { "EmptyList", "<h1>Lista vacía de formas!</h1>"},
                    { "ReportTitle", "<h1>Reporte de Formas</h1>"}
#endregion
                }
            },
            {
             3,
                 new Dictionary<string, string>
                 {
#region shapes
                     { "Square", "Quadrato" },
                    { "Squares", "Quadrati" },
                    { "Circle", "Cerchio" },
                    { "Circles", "Cerchi" },
                    { "Triangle", "Triangolo" },
                    { "Triangles", "Triangoli" },
#endregion
#region messages
                    { "EmptyList", "<h1>Lista vuota di forme!</h1>"},
                    { "ReportTitle", "<h1>Report di Forme</h1>"}
#endregion
                 }
            }
        };

        public static string Translate(string text, int lang)
        {
            if (Translations.ContainsKey(lang) && Translations[lang].ContainsKey(text))
            {
                return Translations[lang][text];
            }

            return text;
        }
    }
}

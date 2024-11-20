using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Services
{
    public static class TranslateService
    {
        private static readonly Dictionary<int, Dictionary<string, (string Singular, string Plural)>> Translations =
            new Dictionary<int, Dictionary<string, (string Singular, string Plural)>>
            {
            {
                1, // EN
                new Dictionary<string, (string Singular, string Plural)>
                {
#region shapes
                    { "Square", ("Square", "Squares") },
                    { "Circle", ("Circle", "Circles") },
                    { "Triangle", ("Triangle", "Triangles") },
                    { "Trapezoid", ("Trapezoid", "Trapezoids")},
#endregion
#region messages
                    { "Shapes", ("shape", "shapes") },
                    { "Total", ("Total", "Totals") }, 
                    { "Perimeter", ("Perimeter", "Perimeters") },
                    { "Area", ("Area", "Areas") },
                    { "ReportTitle", ("<h1>Shapes report</h1>","")},
                    { "EmptyList", ("<h1>Empty list of shapes!</h1>", "")}
#endregion
                }
            },
            {
                2, // ES
                new Dictionary<string, (string Singular, string Plural)>
                {
#region shapes
                    { "Square", ("Cuadrado", "Cuadrados") },
                    { "Circle", ("Círculo", "Círculos") },
                    { "Triangle", ("Triángulo", "Triángulos") },
                    { "Trapezoid", ("Trapecio", "Trapecios")},

#endregion
#region messages
                    { "Shapes", ("forma", "formas") },
                    { "Total", ("Total", "Totales") },
                    { "Perimeter", ("Perímetro", "Perímetros") },
                    { "Area", ("Área", "Áreas") },
                    { "ReportTitle", ("<h1>Reporte de Formas</h1>","")},
                    { "EmptyList", ("<h1>Lista vacía de formas!</h1>", "")}
#endregion
                }
            },
            {
                3, // IT
                new Dictionary<string, (string Singular, string Plural)>
                {
#region shapes
                    { "Square", ("Quadrato", "Quadrati") },
                    { "Circle", ("Cerchio", "Cerchi") },
                    { "Triangle", ("Triangolo", "Triangoli") },
                    { "Trapezoid", ("Trapezio", "Trapezi")},

#endregion
#region messages
                    { "Shapes", ("forma", "forme") },
                    { "Total", ("Totale", "Totali") },
                    { "Perimeter", ("Perimetro", "Perimetri") },
                    { "Area", ("Area", "Aree") },
                    { "ReportTitle", ("<h1>Report di Forme</h1>","")},
                    { "EmptyList", ("<h1>Lista vuota di forme!</h1>", "")}
#endregion
                }
            }
            };

        public static string Translate(string text, int lang, int quantity = 1)
        {
            if (Translations.ContainsKey(lang) && Translations[lang].ContainsKey(text))
            {
                var (singular, plural) = Translations[lang][text];
                return quantity == 1 ? singular : plural;
            }

            return text; 
        }
    }

}

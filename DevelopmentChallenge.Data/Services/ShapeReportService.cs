using DevelopmentChallenge.Data.Constants;
using DevelopmentChallenge.Data.Shapes;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Services
{
    public class ShapeReportService
    {
        public string PrintShapeReport(List<GeometricShape> shapes, int lang)
        {
            var reportStringBuilder = new StringBuilder();

            if (!shapes.Any())
                return reportStringBuilder.Append(TranslateService.Translate(MessageLabel.EmptyList, lang)).ToString();

            reportStringBuilder.Append(TranslateService.Translate(MessageLabel.ReportTitle, lang));


            var result = shapes
                .GroupBy(s => s.Type)
                .Select(group => new
                {
                    Type = group.Key,
                    Count = group.Count(),
                    TotalArea = group.Sum(f => f.CalculateArea()),
                    TotalPerimeter = group.Sum(f => f.CalculatePerimeter())
                });

            foreach (var item in result)
            {

                reportStringBuilder.Append($"{item.Count} {TranslateService.Translate(item.Type, lang, item.Count)} | " +
                    $"{TranslateService.Translate(MessageLabel.Area, lang)} {item.TotalArea:#.##} | " +
                    $"{TranslateService.Translate(MessageLabel.Permieter, lang)} {item.TotalPerimeter:#.##} <br/>");
            }

            reportStringBuilder.Append($"{TranslateService.Translate(MessageLabel.Total.ToUpper(), lang)}:<br/>");
            reportStringBuilder.Append($"{shapes.Count()} {TranslateService.Translate(MessageLabel.Shapes, lang, shapes.Count())} ");
            reportStringBuilder.Append($"{TranslateService.Translate(MessageLabel.Permieter, lang)} {shapes.Sum(x => x.CalculatePerimeter()):#.##} ");
            reportStringBuilder.Append($"{TranslateService.Translate(MessageLabel.Area, lang)} {shapes.Sum(x => x.CalculateArea()):#.##}");

            return reportStringBuilder.ToString();

        }

      
    }
}

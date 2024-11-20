using DevelopmentChallenge.Data.Constants;
using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                reportStringBuilder.Append($"{item.Count} {TranslateService.Translate(Enum.GetName(typeof(ShapeEnum), item.Type), lang)} |" +
                    $" {TranslateService.Translate(MessageLabel.Area, lang)}");
            }

            return reportStringBuilder.ToString();

        }

      
    }
}

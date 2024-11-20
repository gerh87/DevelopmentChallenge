using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Constants;
using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Services;
using DevelopmentChallenge.Data.Shapes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            var reportService = new ShapeReportService();
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>", reportService.PrintShapeReport(new List<GeometricShape>(), (int)LangEnum.es)); //2=SP
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            var reportService = new ShapeReportService();
            Assert.AreEqual("<h1>Empty list of shapes!</h1>", reportService.PrintShapeReport(new List<GeometricShape>(), (int)LangEnum.en)); //1=EN
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<GeometricShape> { new Square(5) };
            var reportService = new ShapeReportService();
            var summary = reportService.PrintShapeReport(cuadrados, (int)LangEnum.es);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Área 25 | Perímetro 20 <br/>TOTAL:<br/>1 forma Perímetro 20 Área 25", summary);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<GeometricShape>
            {
                new Square(5),
                new Square(1),
                new Square(3)
            };
            var reportService = new ShapeReportService();
            var summary = reportService.PrintShapeReport(cuadrados, (int)LangEnum.en);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", summary);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var shapes = new List<GeometricShape>
            {
                new Square(5),
                new Circle(3),
                new EquilateralTriangle(4),
                new Square(2),
                new EquilateralTriangle(9),
                new Circle(2.75m),
                new EquilateralTriangle(4.2m)
            };
            var reportService = new ShapeReportService();
            var summary = reportService.PrintShapeReport(shapes, (int)LangEnum.en);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                summary);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var shapes = new List<GeometricShape>
            {
                new Square(5),
                new Circle(3),
                new EquilateralTriangle(4),
                new Square(2),
                new EquilateralTriangle(9),
                new Circle(2.75m),
                new EquilateralTriangle(4.2m)
            };
            var reportService = new ShapeReportService();
            var summary = reportService.PrintShapeReport(shapes, (int)LangEnum.es);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Área 29 | Perímetro 28 <br/>2 Círculos | Área 13,01 | Perímetro 18,06 <br/>3 Triángulos | Área 49,64 | Perímetro 51,6 <br/>TOTAL:<br/>7 formas Perímetro 97,66 Área 91,65",
                summary);
        }

        [TestCase]
        public void TranslateEmptyListShoulBeSuccess()
        {
            var shapes = new List<GeometricShape>();
            var reportService = new ShapeReportService();
            var summary = reportService.PrintShapeReport(shapes, (int)LangEnum.en);

            Assert.AreEqual("<h1>Empty list of shapes!</h1>", summary);
        }
    }
}

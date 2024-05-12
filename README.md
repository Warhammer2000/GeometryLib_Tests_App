# GeometryLib_Tests_App

## **Задание:**

Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

- Юнит-тесты
- Легкость добавления других фигур
- Вычисление площади фигуры без знания типа фигуры в compile-time
- Проверку на то, является ли треугольник прямоугольным 

  

GeometrySolutions
|
|-- GeometryLib
|   |-- GeometryLib.sln
|   |-- GeometryLib
|       |-- GeometryLib.csproj
|       |-- Shapes
|           |-- Circle.cs
|           |-- Quadrilateral.cs
|           |-- Triangle.cs
|           |-- Rhombus.cs
|       |-- IShape.cs
|       |-- ShapeFactory.cs
|       |-- Program.cs
|
|-- GeometryApp
|   |-- GeometryApp.sln
|   |-- GeometryApp
|       |-- GeometryApp.csproj
|       |-- Program.cs
|
|-- GeometryLib.Tests
    |-- GeometryLib.Tests
        |-- GeometryTests.cs

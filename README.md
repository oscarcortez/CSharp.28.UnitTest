# CSharp.28.UnitTest

Para crear unit test se debe crear un proyecto ms test

se debe importar este library:
```csharp
using Microsoft.VisualStudio.TestTools.UnitTesting;
```

usar este anotation en la clase
```csharp 
[TestClass]
```

usar este anotation en los metodos
```csharp
[TestMethod]
```

el nombre del metodo usualmente es:
```csharp
public void GetCustomer_ShouldGetSameCustomer(){}
// NombreMetodo_deberiaRetornarEsteValor
```

un TestMethod tiene 3 secciones
Arrange:
```csharp
// initial declaring values
Customer[] customers = new Customer[2]
{
  new Customer { FirstName = "jhon", LastName = "ford"},
  new Customer(){ FirstName = "jhon2", LastName = "ford2"}
};

int index = 1;
Customer expectedResult = customers[index];
```

Act:
```csharp
// using the method to be tested
Customer actualResult = CollectionSample.GetCustomer(customers, index);
```

Assert:
```csharp
// assert
Assert.IsInstanceOfType(actualResult, typeof(Customer));
Assert.AreEqual(expectedResult, actual: actualResult);
```

Aditionally there are other decorators
DataRow sirve para asignar los input parameters y se ejecute cada datarow agregado
```csharp
[DataRow(5,5,10)]
[DataRow(5, 15, 20)]
[TestMethod]
public void Sum_ShouldCalcAndReturnSameValue(int a, int b, int expectedResult)
```

Si lo esperado es una exception se agrega este decorator:
```csharp
[ExpectedException(typeof(IndexOutOfRangeException))]
```

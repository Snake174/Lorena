using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Lorena.UnitTests
{
  [TestFixture]
  public class SalonTests
  {
    [Test]
    public void getSumAmelia()
    {
      Salon target = new Salon();
      target.id = 2;
      target.pid = 1;
      target.name = "Амелия";
      target.discount = 5.0F;
      target.depend = 1;
      target.description = "Описание для Амелия";

      float price = 5360.0F;
      float expected = 4877.6F;
      float actual = target.getSum( price );

      Assert.AreEqual( expected, actual );
    }

    [Test]
    public void getSumTest1()
    {
      Salon target = new Salon();
      target.id = 3;
      target.pid = 2;
      target.name = "Тест1";
      target.discount = 2.0F;
      target.depend = 1;
      target.description = "Описание для Тест1";

      float price = 136540.0F;
      float expected = 121520.6F;
      float actual = target.getSum( price );

      Assert.AreEqual( expected, actual );
    }

    [Test]
    public void getSumTest2()
    {
      Salon target = new Salon();
      target.id = 4;
      target.pid = 1;
      target.name = "Тест2";
      target.discount = 0.0F;
      target.depend = 1;
      target.description = "Описание для Тест2";

      float price = 54054.0F;
      float expected = 51891.84F;
      float actual = target.getSum( price );

      Assert.AreEqual( expected, actual );
    }

    [Test]
    public void getSumKurgan()
    {
      Salon target = new Salon();
      target.id = 5;
      target.pid = 0;
      target.name = "Курган";
      target.discount = 11.0F;
      target.depend = 0;
      target.description = "Описание для Курган";

      float price = 57850F;
      float expected = 51486.5F;
      float actual = target.getSum( price );

      Assert.AreEqual( expected, actual );
    }

    [Test]
    public void getSumMiass()
    {
      Salon target = new Salon();
      target.id = 1;
      target.pid = 0;
      target.name = "Миасс";
      target.discount = 4.0F;
      target.depend = 0;
      target.description = "Описание для Миасс";

      float price = 57470F;
      float expected = 55171.2F;
      float actual = target.getSum( price );

      Assert.AreEqual( expected, actual );
    }
  }
}

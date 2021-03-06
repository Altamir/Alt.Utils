﻿using System.Collections.Generic;
using System.Linq;
using Alt.Util.Classes;
using Alt.Util.Interfaces;
using NUnit.Framework;

namespace Alt.Utils.Tests
{
    public class Car
    {
        public string Name { get; set; }
    }

    [TestFixture]
    public class MaybeTest
    {
        [Test]
        public void Test_Imay_not_null()
        {
            IMaybe<Car> mayCar = Maybe<Car>.None;
            Assert.IsNotNull(mayCar);
        }

        [Test]
        public void Test_Imay_not()
        {
            IMaybe<Car> mayCar = default(Maybe<Car>);

            Assert.IsNotNull(mayCar);
            Assert.IsFalse(mayCar.HasValue);
        }


        [Test]
        public void Test_tentar_pegar_valor_caom_error()
        {
            IMaybe<Car> mayCar = default(Maybe<Car>);

            Assert.IsNotNull(mayCar);
            Assert.IsFalse(mayCar.HasValue);
            Assert.IsNull(mayCar.Value);
            Assert.AreEqual(mayCar.Error, "unknown error");
        }

        [Test]
        public void Test_Imay_Sem_Valo()
        {
            IMaybe<Car> mayCar = Maybe<Car>.None;
            Assert.IsTrue(!mayCar.HasValue);
        }

        [Test]
        public void Test_Imay_Sem_valor_com_msg_errors()
        {
            IMaybe<Car> mayCar = Maybe<Car>.WithErrors(new List<string> { "Error test" });
            Assert.IsTrue(!mayCar.HasValue);
            Assert.AreEqual(mayCar.Errors.Single(), "Error test");
        }

        [Test]
        public void Test_Imay_Sem_valor_com_msg_error()
        {
            IMaybe<Car> mayCar = Maybe<Car>.WithError("Error test");
            Assert.IsTrue(!mayCar.HasValue);
            Assert.AreEqual(mayCar.Error, "Error test");
        }

        [Test]
        public void Test_Imay_Com_valor_()
        {
            IMaybe<Car> mayCar = Maybe<Car>.Some(new Car() { Name = "car test" });
            Assert.IsTrue(mayCar.HasValue);
            Assert.AreEqual(mayCar.Value.Name, "car test");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Test_C_Seq4
{
    C_Seq4 instA;

    [SetUp]
    public void Setup()
    {
        instA = new C_Seq4(1.0F, 2.0F, 5.0F, 8.0F);
    }

    [Test]
    public void Test_C_Seq3SimplePasses()
    {
        //Set to pass as baseline. 
        Assert.True(true);
    }

    [Test]
    public void Test_C_Seq2Creation()
    {
        //Test the setup initalization. 
        Assert.AreEqual(1.0F, instA.E0);
        Assert.AreEqual(2.0F, instA.E1);
        Assert.AreEqual(5.0F, instA.E2);
        Assert.AreEqual(8.0F, instA.E3);
        Assert.AreNotEqual(1.0F, instA.E3);
        Assert.AreNotEqual(2.0F, instA.E2);
        Assert.AreNotEqual(1.0F, instA.E1);
        Assert.AreNotEqual(5.0F, instA.E0);
    }

    [Test]
    public void Test_C_Seq2GetElement()
    {
        //Test the setup initalization. 
        Assert.AreEqual(1.0F, instA.GetElement(0));
        Assert.AreEqual(2.0F, instA.GetElement(1));
        Assert.AreEqual(5.0F, instA.GetElement(2));
        Assert.AreEqual(8.0F, instA.GetElement(3));
        Assert.AreNotEqual(2.0F, instA.GetElement(3));
        Assert.AreNotEqual(1.0F, instA.GetElement(2));
        Assert.AreNotEqual(5.0F, instA.GetElement(1));
        Assert.AreNotEqual(8.0F, instA.GetElement(0));
    }
}

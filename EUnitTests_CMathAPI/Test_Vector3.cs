using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Test_CVec3_Shorthand
{
    [Test]
    public void Test_C_Vec3_One()
    {
        Assert.True(new C_V3(1.0F, 1.0F, 1.0F) == C_V3.One);
    }

    [Test]
    public void Test_C_Vec3_Zero()
    {
        Assert.True(new C_V3(0.0F, 0.0F, 0.0F) == C_V3.Zero);
    }

    [Test]
    public void Test_C_Vec3_Right()
    {
        Assert.True(new C_V3(1.0F, 0.0F, 0.0F) == C_V3.Right);
    }

    [Test]
    public void Test_C_Vec3_Left()
    {
        Assert.True(new C_V3(-1.0F, 0.0F, 0.0F) == C_V3.Left);
    }

    [Test]
    public void Test_C_Vec3_Up()
    {
        Assert.True(new C_V3(0.0F, 1.0F, 0.0F) == C_V3.Up);
    }

    [Test]
    public void Test_C_Vec3_Down()
    {
        Assert.True(new C_V3(0.0F, -1.0F, 0.0F) == C_V3.Down);
    }

    [Test]
    public void Test_C_Vec3_FWD()
    {
        Assert.AreEqual(new C_V3(0.0F, 0.0F, 1.0F), C_V3.Forward);
    }

    [Test]
    public void Test_C_Vec3_BCK()
    {
        Assert.True(new C_V3(0.0F, 0.0F, -1.0F) == C_V3.Backward);
    }

    [Test]
    public void Test_C_Vec3_PosInfin()
    {
        Assert.True(new C_V3(
            float.PositiveInfinity, 
            float.PositiveInfinity, 
            float.PositiveInfinity) !=
            C_V3.PositiveInfinity);
    }

    [Test]
    public void Test_C_Vec3_NegInfin()
    {
        Assert.True(new C_V3(
            float.NegativeInfinity, 
            float.NegativeInfinity,
            float.NegativeInfinity
            ) !=
            C_V3.NegativeInfinity);
    }
}

public class Test_CVec3_Funcs
{
    C_V3 vec;

    [SetUp]
    public void Setup()
    {
        vec = new C_V3(1.0F, 2.0F, 1.0f);
    }

    [Test]
    public void Test_C_Vec3_Set()
    {
        //Check single axis numbers. 
        C_V3 vec = new C_V3(1.0F, 2.0F, 1.0F);
        C_V3 b = new C_V3(1.0F, 0.0F, 0.0F);
        vec.Set(b.x, b.y, b.z);
        Assert.AreEqual(b, vec);

        vec = new C_V3(1.0F, 2.0F, 1.0F);
        b = new C_V3(0.0F, 1.0F, 0.0F);
        vec.Set(b.x, b.y, b.z);
        Assert.AreEqual(b, vec);

        vec = new C_V3(1.0F, 2.0F, 1.0F);
        b = new C_V3(0.0F, 0.0F, 1.0F);
        vec.Set(b.x, b.y, b.z);
        Assert.AreEqual(b, vec);

        vec = new C_V3(1.0F, 2.0F, 1.0F);
        b = new C_V3(-1.0F, 0.0F, 0.0F);
        vec.Set(b.x, b.y, b.z);
        Assert.AreEqual(b, vec);

        vec = new C_V3(1.0F, 2.0F, 1.0F);
        b = new C_V3(0.0F, -1.0F, 0.0F);
        vec.Set(b.x, b.y, b.z);
        Assert.AreEqual(b, vec);

        vec = new C_V3(1.0F, 2.0F, 1.0F);
        b = new C_V3(0.0F, 0.0F, -1.0F);
        vec.Set(b.x, b.y, b.z);
        Assert.AreEqual(b, vec);

        //Test positive numbers.
        vec = new C_V3(1.0F, 2.0F, 1.0F);
        b = new C_V3(4.0F, 8.0F, 2.0F);
        vec.Set(b.x, b.y, b.z);
        Assert.AreEqual(b, vec);

        vec = new C_V3(5.0F, 6.0F, 9.0F);
        b = new C_V3(5.0F, 6.0F, 9.0F);
        vec.Set(b.x, b.y, b.z);
        Assert.AreEqual(b, vec);

        //Test negative numbers.

        vec = new C_V3(5.0F, 6.0F, 9.0F);
        b = new C_V3(-5.0F, 6.0F, 9.0F);
        vec.Set(b.x, b.y, b.z);
        Assert.AreEqual(b, vec);

        vec = new C_V3(5.0F, 6.0F, 9.0F);
        b = new C_V3(-5.0F, -6.0F, 9.0F);
        vec.Set(b.x, b.y, b.z);
        Assert.AreEqual(b, vec);

        vec = new C_V3(5.0F, 6.0F, 9.0F);
        b = new C_V3(-5.0F, -6.0F, -9.0F);
        vec.Set(b.x, b.y, b.z);
        Assert.AreEqual(b, vec);
    }

    [Test]
    public void Test_C_Vec3_CopyTo()
    {
        C_V3 vec = new C_V3(2.0F, 5.0F, 4.0F);
        C_V3 b = C_V3.One; 

        Assert.AreNotEqual(b, vec);
        C_V3.CopyTo(b, ref vec);
        Assert.AreEqual(b, vec);
 
        b = C_V3.Zero; 
        Assert.AreNotEqual(b, vec);
        C_V3.CopyTo(b, ref vec);
        Assert.AreEqual(b, vec);

        b = C_V3.Up; 
        Assert.AreNotEqual(b, vec);
        C_V3.CopyTo(b, ref vec);
        Assert.AreEqual(b, vec);

        b = C_V3.Down; 
        C_V3.CopyTo(b, ref vec);
        Assert.AreEqual(b, vec);
    }

    [Test]
    public void Test_C_Vec3_Min()
    {
        C_V3 _vec = new C_V3(1.0F, 2.0F, 1.0f);
        C_V3 _vecB = new C_V3(0.5F, 4.0F, -1.0F); 
        C_V3 result = new C_V3(0.5F, 2.0F, -1.0F);
        Assert.AreEqual(result, C_V3.Min(_vec, _vecB));

        _vec = new C_V3(-1.0F, 2.0F, -2.0f);
        _vecB = new C_V3(0.5F, 4.0F, -1.0F);
        result = new C_V3(-1.0F, 2.0F, -2.0F);
        Assert.AreEqual(result, C_V3.Min(_vec, _vecB));

        _vec = new C_V3(-4.0F, -12.0F, -2.0f);
        _vecB = new C_V3(-0.5F, -11.0F, -1.0F);
        result = new C_V3(-4.0F, -12.0F, -2.0F);
        Assert.AreEqual(result, C_V3.Min(_vec, _vecB));
    }

    [Test]
    public void Test_C_Vec3_Max()
    {
        C_V3 _vec = new C_V3(1.0F, 2.0F, 1.0f);
        C_V3 _vecB = new C_V3(0.5F, 4.0F, -1.0F);
        C_V3 result = new C_V3(1.0F, 4.0F, 1.0F);
        Assert.AreEqual(result, C_V3.Max(_vec, _vecB));

        _vec = new C_V3(-1.0F, 2.0F, -2.0f);
        _vecB = new C_V3(0.5F, 4.0F, -1.0F);
        result = new C_V3(0.5F, 4.0F, -1.0F);
        Assert.AreEqual(result, C_V3.Max(_vec, _vecB));

        _vec = new C_V3(-4.0F, -12.0F, -2.0f);
        _vecB = new C_V3(-0.5F, -11.0F, -1.0F);
        result = new C_V3(-0.5F, -11.0F, -1.0F);
        Assert.AreEqual(result, C_V3.Max(_vec, _vecB));
    }

    [Test]
    public void Test_C_Vec3_Clamp()
    {
        C_V3 result; 
        C_V3 vec = new C_V3(-1.0F, 1.0F, 12.0F);
        C_V2 ntp = new C_V2(-1.0F, 1.0F);
        C_V2 ztp = new C_V2(0.0F, 1.0F);
        C_V2 ztz = new C_V2(0.0F, 0.0F);

        result = C_V3.Clamp(vec, ztz, ztz, ztz);
        Assert.AreEqual(C_V3.Zero, result);

        vec = new C_V3(-1.0F, 1.0F, 12.0F);
        result = C_V3.Clamp(vec, ntp, ztz, ztz);
        Assert.AreEqual(C_V3.Left, result);

        vec = new C_V3(1.0F, 1.0F, 12.0F);
        result = C_V3.Clamp(vec, ntp, ztz, ztz);
        Assert.AreEqual(C_V3.Right, result);

        vec = new C_V3(1.0F, 1.0F, 12.0F);
        result = C_V3.Clamp(vec, ztz, ntp, ztz);
        Assert.AreEqual(C_V3.Up, result);

        vec = new C_V3(1.0F, -1.0F, 12.0F);
        result = C_V3.Clamp(vec, ztz, ntp, ztz);
        Assert.AreEqual(C_V3.Down, result);

        vec = new C_V3(1.0F, 1.0F, 12.0F);
        result = C_V3.Clamp(vec, ztz, ztz, ntp);
        Assert.AreEqual(C_V3.Forward, result);

        vec = new C_V3(1.0F, 1.0F, -120.0F);
        result = C_V3.Clamp(vec, ztz, ztz, ntp);
        Assert.AreEqual(C_V3.Backward, result);

        vec = new C_V3(1.0F, 1.0F, 1200.0F);
        result = C_V3.Clamp(vec, ztp, ztp, ntp);
        Assert.AreEqual(C_V3.One, result);

        vec = new C_V3(-1000.0F, -1000.0F, -1200.0F);
        result = C_V3.Clamp(vec, ntp, ntp, ntp);
        Assert.AreEqual(-1 * C_V3.One, result);
    }

    [Test]
    public void Test_C_Vec3_Abs()
    { 
        //Negative x
        Assert.AreEqual(new C_V3(1.0F, 20.0F, 2.0F),
            C_V3.Abs(new C_V3(-1.0F, 20.0F, 2.0F)));
        
        //Negative xy
        Assert.AreEqual(new C_V3(1.0F, 20.0F, 2.0F),
            C_V3.Abs(new C_V3(-1.0F, -20.0F, 2.0F)));
        
        //Negative yz
        Assert.AreEqual(new C_V3(1.0F, 20.0F, 4.0F),
            C_V3.Abs(new C_V3(1.0F, -20.0F, -4.0F)));

        //Negative xyz.
        Assert.AreEqual(new C_V3(1.0F, 20.0F, 4.0F),
            C_V3.Abs(new C_V3(-1.0F, -20.0F, -4.0F)));

        //Positive xyz. 
        Assert.AreEqual(new C_V3(1.0F, 20.0F, 4.0F),
            C_V3.Abs(new C_V3(1.0F, 20.0F, 4.0F)));
    }

    [Test]
    public void Test_C_Vec3_Normalize()
    {
        ///RHS negative. 
        C_V3 c1 = new C_V3(-1.0F, 0.0F, 0.0F);
        c1.Normalize();
        float denom = Mathf.Sqrt((-1) * (-1) + 0 * 0 + (0 * 0));
        Assert.AreEqual(new C_V3(-1.0F, 0.0F, 0.0F), c1);

        c1 = new C_V3(-0.5F, 0.5F, 0.5F);
        C_V3 v2 = new C_V3(c1.x, c1.y, c1.z);
        c1.Normalize();
        denom = v2.Magnitude;
        Assert.AreEqual(v2/denom, c1);
    }

    [Test]
    public void Test_C_Vec3_DotProduct()
    {
        ///TODO: Edit these tests so they actually do check the function. 
        C_V3 a = new C_V3(0.0F, -1.0F, 1.0F);
        C_V3 b = new C_V3(0.0F, 1.0F, 1.0F);
        Assert.AreEqual(0, C_V3.DotProduct(a, b));

        a = new C_V3(1.0F, 1.0F, 0.0F);
        b = new C_V3(1.0F, 1.0F, 0.0F);
        Assert.AreEqual(2, C_V3.DotProduct(a, b));

        a = new C_V3(1.0F, 1.0F, 1.0F);
        b = new C_V3(1.0F, 1.0F, 1.0F);
        Assert.AreEqual(3, C_V3.DotProduct(a, b));

        a = new C_V3(1.0F, 0.0F, 1.0F);
        b = new C_V3(0.0F, 1.0F, 1.0F);
        Assert.AreEqual(1.0F, C_V3.DotProduct(a, b));

        a = new C_V3(-1.0F, 0.0F, 1.0F);
        b = new C_V3(0.0F, -1.0F, 1.0F);
        Assert.AreEqual(1.0F, C_V3.DotProduct(a, b));

        a = new C_V3(2.5F, 2.5F, 1.0F);
        b = new C_V3(1.0F, 0.0F, 1.0F);
        Assert.AreEqual(3.5F, C_V3.DotProduct(a, b));
    }

    [Test]
    public void Test_C_Vec3_NormDotProduct()
    {

        //TODO: Fix this unit test pls, past me was far too tired. 
        C_V3 a = new C_V3(2.0F, -2.0F, 2.0F);
        C_V3 b = new C_V3(-2.0F, 2.0F, 2.0F);
        Assert.AreEqual(-1, C_V3.NormDotProduct(a, b));

        a = new C_V3(-0.0F, 1.0F, 0.0F);
        b = new C_V3(-0.0F, -1.0F, 0.0F);
        Assert.AreEqual(1, C_V3.NormDotProduct(a, b));
    }

    [Test]
    public void Test_C_Vec3_AngleBetween()
    {
        C_V3 a = new C_V3(0.0F, -1.0F, 0.0F);
        C_V3 b = new C_V3(0.0F, 1.0F, 0.0F);
        Assert.AreEqual(Mathf.Acos(-1), C_V3.AngleBetween(a, b));

        a = new C_V3(0.0F, 1.0F, 1.0F);
        b = new C_V3(0.0F, 1.0F, 1.0F);
        Assert.AreEqual(Mathf.Acos(1), C_V3.AngleBetween(a, b));

        a = new C_V3(1.0F, 0.0F, 1.0F);
        b = new C_V3(0.0F, 1.0F, 1.0F);
        Assert.AreEqual(Mathf.Acos(0.0F), C_V3.AngleBetween(a, b));

        a = new C_V3(-1.0F, 0.0F, -1.0F);
        b = new C_V3(0.0F, -1.0F, -1.0F);
        Assert.AreEqual(Mathf.Acos(0.0F), C_V3.AngleBetween(a, b));

        a = new C_V3(2.5F, 2.5F, 4).Normalized;
        b = new C_V3(1.0F, 0.0F, 4).Normalized;
        Assert.AreEqual(0.707106769F, C_V3.DotProduct(a, b));
    }

    public void Test_C_Vec3_CrossProduct()
    {
        C_V3 a = new C_V3(4, 3, 2);
        C_V3 b = new C_V3(12, 9, 2);

        C_V3 aCrossB = new((a.y * b.z) - (a.z * b.y),
            (a.z * b.x) - (a.x * b.z),
            (a.x * b.y) - (a.y * b.x));

        Assert.AreEqual(aCrossB, C_V3.CrossProduct(a, b));

        a = new C_V3(5, 6, 4);
        b = new C_V3(15, 12, 4);

        aCrossB = new((a.y * b.z) - (a.z * b.y),
            (a.z * b.x) - (a.x * b.z),
            (a.x * b.y) - (a.y * b.x));

        Assert.AreEqual(aCrossB, C_V3.CrossProduct(a, b));
    }
}

public class Test_CVec3_Operators
{
    [Test]
    public void Test_C_Vec3_AdditionCVec3()
    {

        ///Expand this unit test with more cases. 
        Assert.AreEqual(new C_V3(0.0F, 0.0F, 0.0F),
            new C_V3(0.0F, -1.0F, -2.0F) + new C_V3(0.0F, 1.0F, 2.0F));

        Assert.AreEqual(new C_V3(0.0F, 2.0F, 4F),
            new C_V3(0.0F, 1.0F, 1.0F) + new C_V3(0.0F, 1.0F, 3.0F));

        Assert.AreEqual(new C_V3(1.0F, 1.0F, 6.5F),
            new C_V3(1.0F, 0.0F, 3.25F) + new C_V3(0.0F, 1.0F, 3.25F));
    }

    [Test]
    public void Test_C_Vec3_SubtractionCVec3()
    {
        ///Expand this unit test with more cases. 
        Assert.True(new C_V3(0.0F, 0.0F, 0.0F) == C_V3.Zero - C_V3.Zero);

        Assert.True(new C_V3(0.0F, -1.0F, 0.0F) == C_V3.Zero - C_V3.Up);

        Assert.True(new C_V3(1.0F, -1.0F, 0.0F) == C_V3.Right - C_V3.Up);
    }

    [Test]
    public void Test_C_Vec3_MultiplicationCVec3()
    {
        ///Expand this unit test with more cases. 

        Assert.AreEqual(new C_V3(0.0F, -1.0F, 0.5f),
            new C_V3(0.0F, -1.0F, 0.5F) * new C_V3(0.0F, 1.0F, 1.0F));

        Assert.AreEqual(new C_V3(0.0F, 1.0F, 3.0F),
            new C_V3(0.0F, 1.0F, 1.0F) * new C_V3(0.0F, 1.0F, 3.0F));

        Assert.AreEqual(new C_V3(0.0F, 0.0F, 0.0F),
            new C_V3(1.0F, 0.0F, 2.0F) * new C_V3(0.0F, 1.0F, 0.0F));
    }

    [Test]
    public void Test_C_Vec3_MultiplicationFloatCVec3()
    {
        ///Expand this unit test with more cases. 
        Assert.AreEqual(new C_V3(0.0F, 2.0F, 4.0F), 2.0F * new C_V3(0.0F, 1.0F, 2.0F));

        Assert.AreEqual(new C_V3(0.0F, 3.0F, 9.0F), 3.0F * new C_V3(0.0F, 1.0F, 3.0F));

        Assert.AreEqual(new C_V3(0.0F, 4.0F, 12.0F), 4.0F * new C_V3(0.0F, 1.0F, 3.0F));
    }

    [Test]
    public void Test_C_Vec3_MultiplicationIntCVec3()
    {
        Assert.AreEqual(new C_V3(0.0F, 2.0F, 2.0F), 2 * new C_V3(0.0F, 1.0F, 1.0F));

        Assert.AreEqual(new C_V3(0.0F, 3.0F, 6.0F), 3 * new C_V3(0.0F, 1.0F, 2.0F));

        Assert.AreEqual(new C_V3(0.0F, 4.0F, 8.0F), 4 * new C_V3(0.0F, 1.0F, 2.0F));
    }

    [Test]
    public void Test_C_Vec3_Equals()
    {
        C_V3 a = new C_V3(0.0F, 1.0F, 0.0F);
        C_V3 b = new C_V3(0.0F, 1.0F, 0.0F);

        Assert.AreEqual(a.x == b.x && a.y == b.y, a == b);

        a = new C_V3(1.0F, 1.0F, 1.0F);
        b = new C_V3(1.0F, 1.0F, 1.0F);
        Assert.AreEqual(a.x == b.x && a.y == b.y, a == b);

        a = new C_V3(0.0F, 4.0F, 2.0F);
        b = new C_V3(1.0F, 1.0F, 2.0F);
        Assert.AreEqual(a.x == b.x && a.y == b.y, a == b);
    }

    [Test]
    public void Test_C_Vec3_NotEquals()
    {
        C_V3 a = new C_V3(1.0F, 1.0F, 1.0F);
        C_V3 b = new C_V3(0.0F, 1.0F, 0.0F);

        Assert.AreEqual(!(a.x != b.x && a.y != b.y), a != b);

        a = new C_V3(1.0F, 0.0F, 0.0F);
        b = new C_V3(1.0F, 1.0F, 0.0F);
        Assert.AreEqual(!(a.x != b.x && a.y != b.y), a != b);

        a = new C_V3(1.0F, 4.0F, 0.0F);
        b = new C_V3(1.0F, 4.0F, 0.0F);
        Assert.AreEqual(!(a.x != b.x && a.y != b.y), a == b);
    }
}

public partial class Test_CVec3_Properties
{
    [Test]
    public void Test_C_Vec3SimplePasses()
    {
        Assert.True(true);
    }

    [Test]
    public void Test_C_Vec3ElementSetting()
    {
        C_V3 vec = new C_V3(1.0F, 2.0F, 4.0F);
        Assert.AreEqual(1.0F, vec.x);
        Assert.AreEqual(2.0F, vec.y);
        Assert.AreEqual(4.0F, vec.z);
    }
}

public partial class Test_CVec3_Utils
{
    C_V3 vec;

    [SetUp]
    public void Setup()
    {
        vec = new C_V3(1.0F, 2.0F, 4.0F);
    }

    [Test]
    public void Test_C_Vec3SimplePasses()
    {
        Assert.True(true);
    }

    [Test]
    public void Test_C_Vec3Init()
    {
        Assert.AreNotEqual(null, vec);
    }

    [Test]
    public void Test_C_Vec3ElementSetting()
    {
        C_V3 vec = new C_V3(1.0F, 2.0F, 4.0F);
        Assert.AreEqual(1.0F, vec.x);
        Assert.AreEqual(2.0F, vec.y);
        Assert.AreEqual(4.0F, vec.z);
    }

    [Test]
    public void Test_C_Vec3_Prop_Normalized()
    {
        ///RHS negative. 
        C_V3 c1 = new C_V3(-1.0F, 0.0F, 4.0F).Normalized;
        float denom = Mathf.Sqrt(((-1) * (-1)) + (0 * 0) + (4.0F * 4.0F));
        Assert.AreEqual(-1.0F / denom, c1.x);
        Assert.AreEqual(0.0F / denom, c1.y);
        Assert.AreEqual(4.0F / denom, c1.z);

        c1 = new C_V3(-0.5F, 0.5F, 4.0F).Normalized;
        denom = Mathf.Sqrt((-0.5F) * (-0.5F) + 0.5F * 0.5F + (4.0F * 4.0F));
        Assert.AreEqual(-0.5F / denom, c1.x);
        Assert.AreEqual(0.5F / denom, c1.y);
        Assert.AreEqual(4.0F / denom, c1.z);
    }
}

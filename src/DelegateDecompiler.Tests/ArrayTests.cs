﻿using System;
using System.Linq.Expressions;
using NUnit.Framework;

namespace DelegateDecompiler.Tests
{
    [TestFixture]
    public class ArrayTests : DecompilerTestsBase
    {
        [Test]
        public void TestNewArray()
        {
            Expression<Func<int[]>> expected = () => new int[] { };
            Func<int[]> compiled = () => new int[] { };
            Test(expected, compiled);
        }

        [Test]
        public void TestNewArray0()
        {
            Expression<Func<int[]>> expected = () => new int[0];
            Func<int[]> compiled = () => new int[0];
            Test(expected, compiled);
        }

        [Test]
        public void TestNewArrayX()
        {
            Expression<Func<int, int[]>> expected = x => new int[x];
            Func<int, int[]> compiled = x => new int[x];
            Test(expected, compiled);
        }

        [Test]
        public void TestNewArray1()
        {
            Expression<Func<int[]>> expected = () => new int[1];
            Func<int[]> compiled = () => new int[1];
            Test(expected, compiled);
        }

        [Test]
        public void DecompileArrayWithBounds()
        {
            Expression<Func<int[]>> expected = () => new int[10];
            Func<int[]> compiled = () => new int[10];
            Test(expected, compiled);
        }

        [Test]
        public void DecompileArrayWithInit()
        {
            Expression<Func<int[]>> expected = () => new[] { 1 };
            Func<int[]> compiled = () => new[] { 1 };
            Test(expected, compiled);
        }

        [Test]
        public void DecompileArrayWithInit2()
        {
            Expression<Func<int[]>> expected = () => new[] { 1, 2 };
            Func<int[]> compiled = () => new[] { 1, 2 };
            Test(expected, compiled);
        }

        [Test]
        public void DecompileArrayOfIntWithInitFromParam()
        {
            Expression<Func<int, int[]>> expected = x => new[] { x, 2 };
            Func<int, int[]> compiled = x => new[] { x, 2 };
            Test(expected, compiled);
        }

        [Test]
        public void DecompileArrayOfClassWithInitFromParam()
        {
            Expression<Func<TestClass, TestClass[]>> expected = x => new[] { new TestClass(), x };
            Func<TestClass, TestClass[]> compiled = x => new[] { new TestClass(), x };
            Test(expected, compiled);
        }
    }
}

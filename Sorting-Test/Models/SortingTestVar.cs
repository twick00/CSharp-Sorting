using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Sorting.Models;

namespace Sorting.Tests
{
    [TestClass]
    public class SortTest
    {
        [TestMethod]
        public void InsertionSort_ReturnsSorted_intList()
        {
            List <int> unsortedIntList = new List<int> {8,5,3,1,2,4,6,9,10,7};
            List <int> intList = new List<int> {1,2,3,4,5,6,7,8,9,10};
            Sort newSort = new Sort();
            newSort.IntInsertionSort(intList);
            Assert.AreEqual(intList, unsortedIntList);
        }
        [TestMethod]
        public void BubbleSort_ReturnsSorted_intList()
        {
            List <int> unsortedIntList = new List<int> {8,5,3,1,2,4,6,9,10,7};
            List <int> intList = new List<int> {1,2,3,4,5,6,7,8,9,10};
            Sort newSort = new Sort();
            newSort.IntBubbleSort(intList);
            Assert.AreEqual(intList, unsortedIntList);
        }
        [TestMethod]
        public void MergeSort_ReturnsSorted_intList()
        {
            List <int> unsortedIntList = new List<int> {8,5,3,1,2,4,0,-1,6,9,10,7};
            List <int> intList = new List<int> {-1,0,1,2,3,4,5,6,7,8,9,10};
            Sort newSort = new Sort();
            newSort.IntMergeSort(intList);
            Assert.AreEqual(intList, unsortedIntList);
        }
    }    
}
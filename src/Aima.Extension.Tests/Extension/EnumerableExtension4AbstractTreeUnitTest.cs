using System;
using Xunit;

namespace Aima.Extension.Tests
{
    using Aima.Extension;
    using System.Collections.Generic;


    public class EnumerableExtension4AbstractTreeUnitTest
    {
        [Fact]
        public void ToTree()
        {

        }

        [Fact]
        public void ToTreeAsGuidId()
        {
            ProductCategory tree = new ProductCategory();
            var productCategoryList = new List<ProductCategory>();
            // productCategoryList.ToArray()

            // productCategoryList.ToTreeAsGuidId();

            productCategoryList.ToTree<ProductCategoryTreeAsIntegerId>();

            // var treeSource = new EmptyGuidIdTree<ProductCategory>(productCategoryList);

            var productCategoryTree = new ProductCategoryTree(productCategoryList);

            // productCategoryTree.ForEach()

            productCategoryTree.DeleteChildrenTree(m => m.ID == Guid.Empty);

            // var produtCategoryTree = productCategoryList.ToTreeAsIntegerId2<ProductCategory, ProductCategoryTree>();

            // treeSource.EachTree()

            // var p = productCategoryList.ToTreeAsIntegerId<ProductCategory, ProductCategoryTree>();
            // ProductCategoryTree t = new List<ProductCategory>().ToTreeAsInteger64Id();
        }
    }
}

namespace Aima.Extension.Tests
{
    using System.Collections.Generic;
    using Aima.Extension.Kernal.Tree.Impl;

    public class ProductCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class ProductCategoryTreeAsIntegerId : EmptyIntegerIdTree
    {

    }
    public class ProductCategoryTree : EmptyGuidIdTree<ProductCategory>
    {
        public ProductCategoryTree(IEnumerable<ProductCategory> productCategories) : base(productCategories)
        {
            // this.DeleteChildrenTree()
        }
    }
}

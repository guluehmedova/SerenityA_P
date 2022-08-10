using MyPages = Smt.Default.Pages;
using Serenity.Navigation;
[assembly: NavigationLink(int.MaxValue, "Default/Brand", typeof(MyPages.BrandController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Brand Category", typeof(MyPages.BrandCategoryController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Category", typeof(MyPages.CategoryController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Model", typeof(MyPages.ModelController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Request", typeof(MyPages.RequestController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Vendor", typeof(MyPages.VendorController), icon: null)]
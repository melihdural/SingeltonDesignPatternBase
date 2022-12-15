// See https://aka.ms/new-console-template for more information


using SingeltonDesignPattern;

ProductA a = Singleton<ProductA>.GetInstance;
ProductB b = Singleton<ProductB>.GetInstance;

a.Main();
b.Main();


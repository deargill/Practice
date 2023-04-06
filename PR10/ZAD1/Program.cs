using Classes;
using Interfaces;

MyClass class1 = new MyClass(10);
MyClass class2 = new MyClass();

class1.IxF1();
class2.IxF0(3);

class1.F1();
class2.F0(3);

(class1 as Iz).F1();
(class2 as Iz).F0(5);

Ix ix = class2;
ix.IxF0(5);
ix.IxF1();

Iy iy = class2;
iy.F0(5);
iy.F1();

Iz iz = class2;
iz.F0(5);
iz.F1();
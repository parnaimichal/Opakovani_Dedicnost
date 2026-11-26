using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices.JavaScript;
using System.Threading.Tasks;
using System;

 class Storage<T>
 {
     public T value;
     public Storage(T value)
     {
         this.value = value;
     }
     
     public T GetValue()
     {
         return value;
     }
 }


 


























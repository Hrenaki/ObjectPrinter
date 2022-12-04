using ObjectPrinting.Common;

namespace ObjectPrinting
{
   namespace ObjectPrinting
   {
      public static class ObjectPrinter
      {
         public static IPrintingConfig<T> For<T>()
         {
            return new PrintingConfig<T>();
         }
      }
   }
}
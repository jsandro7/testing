using System;
using System.Collections;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization;

namespace test2
{
    // public static class Program
    // {    
    //     public static void Main()
    //     {
    //         try
    //         {
    //             ProcessOrder();
    //         }
    //         catch (Exception ex)
    //         {
    //             throw new OrderProcessingException(1, ex.Message);
    //         }
    //     } 
    //     public static void ProcessOrder()
    //     {
    //     }         
    // }

   

    // [Serializable]
    // public class OrderProcessingException : Exception, ISerializable
    // {
    //     public OrderProcessingException(int orderId)
    //     {
    //         OrderId = orderId;
    //         this.HelpLink = "http://www.mydomain.com/infoaboutexception";
    //     }
    //     public OrderProcessingException(int orderId, string message)
    //     : base(message)
    //     {
    //         OrderId = orderId;
    //         this.HelpLink = "http://www.mydomain.com/infoaboutexception";
    //     }
    //     public OrderProcessingException(int orderId, string message,
    //     Exception innerException)
    //     : base(message, innerException)
    //     {
    //         OrderId = orderId;
    //         this.HelpLink = "http://www.mydomain.com/infoaboutexception";
    //     }
    //     protected OrderProcessingException(SerializationInfo info, StreamingContext context)
    //     {
    //         OrderId = (int)info.GetValue("OrderId", typeof(int));
    //     }
    //     public int OrderId { get; private set; }
    //     public void GetObjectData(SerializationInfo info, StreamingContext context)
    //     {
    //         info.AddValue("OrderId", OrderId, typeof(int));
    //     }
    // }  
}
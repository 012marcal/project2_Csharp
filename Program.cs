using project2.Models;

Smartphone i = new Iphone(numero:"11994323861" ,modelo: "XR" ,imei: "123",memoria: 16);



i.InstalarAplicativo("WhatsApp");


i.Numero = "12345678";

Console.Write(i.Numero);
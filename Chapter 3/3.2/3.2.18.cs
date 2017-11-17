// using System;
// using System.IO;
// using System.Security.Cryptography;

// public class MyClass 
// {
//     public static void Main()
//     {
//        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
//         string publicKeyXML = rsa.ToXmlString(false);
//         string privateKeyXML = rsa.ToXmlString(true);
//         Console.WriteLine(publicKeyXML);
//         Console.WriteLine(privateKeyXML);
//     } 
//     // Displays:
//     //<RSAKeyValue>
//     // <Modulus>
//     // tYo35ywT0Q0KCNhFPu207bS8rrTk91YaxNcD2ElQ1eoWpdYnoCsdj1KaW/as9zFLYW5slg5Qq8ltdkxZuU//fh0j2t+7ZFH8RRAD808GkZTrUi1zv3yqMjQDphHOcNfWh+dQrPmp1ShFxEGuA9Y4Ij9RINU5jcfviPa
//     // B1ClLXaGbc=
//     // </Modulus>
//     // <Exponent>AQAB</Exponent>
//     //</RSAKeyValue>
//     //<RSAKeyValue>
//     // <Modulus>
//     // tYo35ywT0Q0KCNhFPu207bS8rrTk91YaxNcD2ElQ1eoWpdYnoCsdj1KaW/as9zFLYW5slg5Qq8ltdkxZuU
//     // fh0j2t+7ZFH8RRAD808GkZTrUi1zv3yqMjQDphHOcNfWh+dQrPmp1ShFxEGuA9Y4Ij9RINU5jcfviPa
//     // B1ClLXaGbc=
//     // </Modulus>
//     // <Exponent>AQAB</Exponent>
//     // <P>
//     // 4uhNaN3cPSUzr+KxHmpKyeaD39RT+kWjjDcn/9sTAV/HmDzFzjsiov3KyJ+3XCXucx5TU0lhDOLc/
//     // cO+Xrquqw==
//     // </P>
//     // <Q>
//     // zNDVw6oL7YNglrFAeqmgIL3Oj2PkUxrWvoYHCbuFwJKpkWvFBRwZfKXHzzU0zaU5bGdX7M24hW8z5s0
//     // eF9CRJQ==
//     // </Q>
//     // <DP>
//     // jkS+/GhWxZPEw5vsF7jnaY3502ZqvPna4HhYwQgX832dRKueDn9vaSidc4sIyWMTDeTOs+LHUfAQRZ/
//     // shbKg/w==
//     // </DP>
//     // <DQ>
//     // HV4QWJboUO0Wi2Ts/umViTxOAudq1LOzeOwU1ENsITmmULCoNlxaFzJaHQ7e/GGlgzKqO80fmRph0c
//     // U1fGqudQ==
//     // </DQ>
//     // <InverseQ>
//     // BW1VUOgXpkRnn2twvb72uxcbK6+o9ns3xa4Ypm+++7vzlg6t/Iyvk94xNJWjjgR+XsSpN6JEtztWol8
//     // bv8HEyA==
//     // </InverseQ>
//     // <D>
//     // IOZUrUNyr+8iA2pWWkowAOhBTZQg7qYfIc8ptjfLO4k544IFGmTV7ZR1vvbcb8vyMk0Vxrf/bLKLcOX
//     // zWL2rMeWYGuoTbZEeUbr0SlmesHARL7X/feCm9MIyPjhlhJieRVG3h4f+TyAVo70jmYVcSou+xAaad3
//     // 7o3Pa8Vny6qIk=
//     // </D>
//     //</RSAKeyValue>
// }
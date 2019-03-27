using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using KurumsalMimari.Core.Aspects.PostsSharp.LogAspects;
using KurumsalMimari.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;

// Bir bütünleştirilmiş koda ilişkin Genel Bilgiler aşağıdaki öznitelikler kümesiyle
// denetlenir. Bütünleştirilmiş kod ile ilişkili bilgileri değiştirmek için
// bu öznitelik değerlerini değiştirin.
[assembly: AssemblyTitle("KurumsalMimari.Northwind.Business")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("KurumsalMimari.Northwind.Business")]
[assembly: AssemblyCopyright("Copyright ©  2019")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: LogAspect(typeof(FileLogger), AttributeTargetTypes = "KurumsalMimari.Northwind.Business.Concrete.Managers.*")]// Bütün Manager'ları logla diyebiliyorum.
[assembly: LogAspect(typeof(DatabaseLogger), AttributeTargetTypes = "KurumsalMimari.Northwind.Business.Concrete.Managers.*")]// Bütün Manager'ları logla diyebiliyorum.
// ComVisible özniteliğinin false olarak ayarlanması bu bütünleştirilmiş koddaki türleri
// COM bileşenleri için görünmez yapar. Bu bütünleştirilmiş koddaki bir türe
// erişmeniz gerekirse ComVisible özniteliğini o türde true olarak ayarlayın.
[assembly: ComVisible(false)]

// Bu proje COM'un kullanımına sunulursa, aşağıdaki GUID tür kitaplığının kimliği içindir
[assembly: Guid("c7ce6e4c-34ca-49f8-bce5-1eede2b9097b")]

// Bir derlemenin sürüm bilgileri aşağıdaki dört değerden oluşur:
//
//      Ana Sürüm
//      İkincil Sürüm 
//      Yapı Numarası
//      Düzeltme
//
// Tüm değerleri belirtebilir veya varsayılan Derleme ve Düzeltme Numaralarını kullanmak için
// '*' kullanarak varsayılana ayarlayabilirsiniz:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

<!-- default file list -->
*Files to look at*:

* **[DynamicDataTableClassInfo.cs](./CS/DynamicDataTableClassInfo.cs) (VB: [DynamicDataTableClassInfo.vb](./VB/DynamicDataTableClassInfo.vb))**
* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->
# How to create an XPClassInfo descendant to dynamically build a persistent class structure


<p>This example is a variation of <a href="https://www.devexpress.com/Support/Center/p/E1198">How to generate persistent classes at runtime based on a dataset </a> with the difference that here we create a custom <a href="http://documentation.devexpress.com/#XPO/clsDevExpressXpoMetadataXPClassInfotopic">XPClassInfo</a> class that provides metadata information for a type.<br /> Then, we will use it to bind the <a href="http://documentation.devexpress.com/#WPF/clsDevExpressWpfGridGridControltopic">GridControl</a> to the <a href="http://documentation.devexpress.com/#XPO/clsDevExpressXpoXPServerCollectionSourcetopic">XPServerCollectionSource</a>, that is necessary to work in the <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument2990">Server Mode</a>.</p>

<br/>



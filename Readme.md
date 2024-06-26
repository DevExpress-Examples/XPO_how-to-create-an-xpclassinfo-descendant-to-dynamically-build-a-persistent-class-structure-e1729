<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128585666/20.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1729)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [DynamicDataTableClassInfo.cs](./CS/DynamicDataTable/DynamicDataTableClassInfo.cs) (VB: [DynamicDataTableClassInfo.vb](./VB/DynamicDataTable/DynamicDataTableClassInfo.vb))
* **[Form1.cs](./CS/DynamicDataTable/Form1.cs) (VB: [Form1.vb](./VB/DynamicDataTable/Form1.vb))**
<!-- default file list end -->
# How to create an XPClassInfo descendant to dynamically build a persistent class structure


<p>This example is a variation of <a href="https://www.devexpress.com/Support/Center/p/E1198">How to generate persistent classes at runtime based on a dataset </a> with the difference that here we create a custom <a href="http://documentation.devexpress.com/#XPO/clsDevExpressXpoMetadataXPClassInfotopic">XPClassInfo</a> class that provides metadata information for a type.<br /> Then, we will use it to bind the <a href="http://documentation.devexpress.com/#WPF/clsDevExpressWpfGridGridControltopic">GridControl</a> to the <a href="http://documentation.devexpress.com/#XPO/clsDevExpressXpoXPServerCollectionSourcetopic">XPServerCollectionSource</a>, that is necessary to work in the <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument2990">Server Mode</a>.</p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=XPO_how-to-create-an-xpclassinfo-descendant-to-dynamically-build-a-persistent-class-structure-e1729&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=XPO_how-to-create-an-xpclassinfo-descendant-to-dynamically-build-a-persistent-class-structure-e1729&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->

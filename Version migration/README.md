# Version migration

This page primarily adresses the need for developers to migrate IDS versions.

A workflow using *Extensible Stylesheet Language Transformer* (XSLT) scripts is suggested as a possible strategy for migrating older IDS files to newer versions. Each script formulates its own transformation for the IDS, updating the naming conventions and general structure of an IDS. Most common XSD/XML parsers are able to use XSLT by default. How and when this transformation should be applied depends on the specific use case. However, we recommend considering the integration of script parsing during loading/uploading to enable older versions to be taken into account in newer applications. 

The general naming convention of the migration files is as following:

- **IDS_{old version}-{new version}_migration.xsl**

Certain files may diverge in the naming convention, such as specialized transformations regardless of versions and order of migration. The scripts content are written based on XSLT 2.0 and XPath 2.0 language extensions. The following order of transformation is recommended for migration into newer versions: 

1. IDS_v0.9.3-v0.9.6_migration 
2. IDS_v0.9.6-v0.9.7_migration
3. IDS_Audit_migration

For execution of those XSLT-scripts, numerouse transformer are available online and hosted for free. On the coding side, developers may look into libraries such as:

- Saxon 9 (Java, .NET, Native, JavaScript) ![feature list](https://www.saxonica.com/html/products/feature-matrix-9-9.html)
- AltovaXML 2008 
- Xalan-J (Java integration)
- Xalan-C++ (C++ integration)

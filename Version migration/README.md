# Version migration

This page primarily adresses the need for developers to migrate IDS versions.

A workflow using *Extensible Stylesheet Language Transformer* (XSLT) scripts is suggested as a possible strategy for migrating older IDS files to newer versions. Each script formulates its own transformation for the IDS, updating the naming conventions and general structure of an IDS. Most common XSD/XML parsers are able to use XSLT by default. How and when this transformation should be applied depends on the specific use case. However, we recommend considering the integration of script parsing during loading/uploading to enable older versions to be taken into account in newer applications. 

The general naming convention of the migration files is as following:

- **IDS_{old version}-{new version}_migration.xsl**

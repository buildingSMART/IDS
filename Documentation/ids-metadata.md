# Guide to effective IDS metadata

IDS is designed to be readable by both humans and computers. Just as it is important to precisely and accurately describe **Specifications** to computers, it is equally important to describe the purpose, intentions, and utility of the **Specifications** to recipients of the IDS. This is achieved by filling out **Specification** metadata. When model authors, designers, engineers, clients, consultants, and other stakeholders clearly understand why information is needed, who it benefits, and when it will be used, it will help guarantee that requirements are met effectively.

## IDS metadata

Each `.ids` file has basic metadata that are common to all **Specifications** listed inside the IDS.

Name | Description | Examples
--- | --- | ---
Title | The document title of the IDS, used to refer to the IDS as a whole | "Minimum delivery requirements" or "Costing Requirements"
Copyright | The copyright owner of the IDS | "Example Company Pty Ltd" or "Government Department X"
Version | The version of the IDS, to keep track of changes that have been made. Semantic versioning is recommended where versioning follows the naming scheme of X.Y, where Y represents a minor change, such as changes in metadata, description, or spelling errors, and X represents a major change, where models that used to pass or fail in a previous version may yield a different result. | "1.0" or "2.1"
Author | The author of the IDS, provided as an email contact address | "john@doe.com"
Date | The date the IDS was published | "2022-01-01"
Description | A short one or two sentence description of what the IDS achieves | "Minimum requirements for all OpenBIM projects to ensure basic coordination and data scheduling can be done by all stakeholders" or "Specifies required properties that have a large impact on the accuracy of cost estimation and quantities that are necessary for automated model-based quantity take-off".
Purpose | ? | ?
Milestone | Which project milestone the IDS should be satisfied in | "Design", "Construction", or "Comissioning"

## Specification metadata

Each **Specification** has metadata to help describe the goals and instructions of how to achieve it.

Name | Description | Examples
--- | --- | ---
Name | A short name of what information is being specified | "Wall type naming conventions" or "Concrete quantity take-off dimensions"
Description | Describe why the requirement is important to the project. The person reading the description should understand why the information provides value, which workflows it helps to achieve, and what project benefits will be sacrificed if the requirements are not met. | "Basic properties that have significant impacts on costing, detailing, and building renovations must be included to minimise construction risk."
Instructions | Provide instructions on who is responsible to provide the information and details on how it is achieved, such as guidelines on how a naming convention works, how to choose an appropriate value, or what to do in edge-cases | "Architects and code consultants are responsible for providing this information. Where there are multiple values, the dominant value shall be indicated."

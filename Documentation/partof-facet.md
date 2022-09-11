# PartOf facet

Objects in IFC can have relationships to other objects. IDS supports specifying four types of relationships.

The **IfcRelAggregates** relationship describes how multiple smaller subobjects can be aggregated into a single bigger object. For example, many building storeys make up a building. Alternatively, many beams, floor boards, and joints make up a slab. Or perhaps many brackets, mullions, and steel plates make up an assembly.

The **IfcRelAssignsToGroup** relationship describes how multiple objects can be grouped into a collection of objects any usecase. For example, ducts, AHUs, fans, and louvres may all be grouped into a single distribution system.  Alternatively, cables, distribution boards, and GPOs may be grouped into a single circuit. Or perhaps spaces are grouped into zones, or maintainable assets are grouped into an inventory.

The **IfcRelContainedInSpatialStructure** relationship describes how multiple objects can be located in a particular location. For example, a pump might be in a space, a column might be on the level 2 building storey, or some street furniture might be on the building site. Every object must have a single primary location container in IFC, even though they may be referenced in multiple locations (such as a multi-storey column). This relationship only targets the primary location container.

The **IfcRelNests** relationship describes how a physical object may be connected to a larger host object, typically through a physical connection such as a pre-drilled hole or connection terminal. When the host moves, the attached nested objects move with it.

## Parameters

Parameter | Required | Restrictions Allowed | Allowed Values | Meaning
--- | --- | --- | --- | ---
**Relation** | ✔️ | ❌ | One relationship chosen from the 4 supported relationships: IfcRelAggregates, IfcRelAssignsToGroup, IfcRelContainedInSpatialStructure, or IfcRelNests | The smaller subobject has the specified relationship with a larger object
**Entity** | ❌ | ✔️ | Any valid IFC class name (e.g. "IFCSYSTEM") | The IFC class of the larger object must match exactly.

## Examples

Applicability Intention | Requirement Intention | Facet Definition
--- | --- | ---
Any entity that is part of a curtain wall | The entity (e.g. mullion) must be part of a curtain wall | Relation="IfcRelAggregates", Entity="IFCCURTAINWALL"
Any entity that is part of a distribution system | The entity (e.g. duct) must be part of a distribution system | Relation="IfcRelAssignsToGroup", Entity="IFCDISTRIBUTIONSYSTEM"
Any entity that is located in a space | The entity (e.g. pump) must be located in a space | Relation="IfcRelContainedInSpatialStructure", Entity="IFCSPACE"
Any entity that hosted by a hand wash basin | The entity (e.g. facuet) must be fixed on a hand wash basin | Relation="IfcRelNests", Entity="IFCSANITARYTERMINAL"

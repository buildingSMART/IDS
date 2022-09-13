# Partof testcases

These testcases are designed to help describe behaviour in edge cases and ambiguities. All valid IDS implementations must demonstrate identical behaviour to these test cases.

## [FAIL] A non aggregated element fails an aggregate relationship

~~~xml
<partOf relation="IfcRelAggregates" minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/partof/fail-a_non_aggregated_element_fails_an_aggregate_relationship.ids) - [Sample IFC: 2](testcases/partof/fail-a_non_aggregated_element_fails_an_aggregate_relationship.ifc)

## [FAIL] The aggregated whole fails an aggregate relationship

~~~xml
<partOf relation="IfcRelAggregates" minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('0eA6m4fELI9QBIhP3wiLAp',$,$,$,#1,(#2));
~~~

[Sample IDS](testcases/partof/fail-the_aggregated_whole_fails_an_aggregate_relationship.ids) - [Sample IFC: 1](testcases/partof/fail-the_aggregated_whole_fails_an_aggregate_relationship.ifc)

## [PASS] The aggregated part passes an aggregate relationship

~~~xml
<partOf relation="IfcRelAggregates" minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#3=IFCRELAGGREGATES('0eA6m4fELI9QBIhP3wiLAp',$,$,$,#1,(#2));
~~~

[Sample IDS](testcases/partof/pass-the_aggregated_part_passes_an_aggregate_relationship.ids) - [Sample IFC: 2](testcases/partof/pass-the_aggregated_part_passes_an_aggregate_relationship.ifc)

## [PASS] A required facet checks all parameters as normal

~~~xml
<partOf relation="IfcRelAggregates" minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#3=IFCRELAGGREGATES('0eA6m4fELI9QBIhP3wiLAp',$,$,$,#1,(#2));
~~~

[Sample IDS](testcases/partof/pass-a_required_facet_checks_all_parameters_as_normal.ids) - [Sample IFC: 2](testcases/partof/pass-a_required_facet_checks_all_parameters_as_normal.ifc)

## [FAIL] A prohibited facet returns the opposite of a required facet

~~~xml
<partOf relation="IfcRelAggregates" minOccurs="0" maxOccurs="0"/>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#3=IFCRELAGGREGATES('0eA6m4fELI9QBIhP3wiLAp',$,$,$,#1,(#2));
~~~

[Sample IDS](testcases/partof/fail-a_prohibited_facet_returns_the_opposite_of_a_required_facet.ids) - [Sample IFC: 2](testcases/partof/fail-a_prohibited_facet_returns_the_opposite_of_a_required_facet.ifc)

## [PASS] An optional facet always passes regardless of outcome 1/2

~~~xml
<partOf relation="IfcRelAggregates" minOccurs="0" maxOccurs="1"/>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('0eA6m4fELI9QBIhP3wiLAp',$,$,$,#1,(#2));
~~~

[Sample IDS](testcases/partof/pass-an_optional_facet_always_passes_regardless_of_outcome_1_2.ids) - [Sample IFC: 1](testcases/partof/pass-an_optional_facet_always_passes_regardless_of_outcome_1_2.ifc)

## [PASS] An optional facet always passes regardless of outcome 2/2

~~~xml
<partOf relation="IfcRelAggregates" minOccurs="0" maxOccurs="1"/>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#3=IFCRELAGGREGATES('0eA6m4fELI9QBIhP3wiLAp',$,$,$,#1,(#2));
~~~

[Sample IDS](testcases/partof/pass-an_optional_facet_always_passes_regardless_of_outcome_2_2.ids) - [Sample IFC: 2](testcases/partof/pass-an_optional_facet_always_passes_regardless_of_outcome_2_2.ifc)

## [PASS] An aggregate may specify the entity of the whole 1/2

~~~xml
<partOf relation="IfcRelAggregates" minOccurs="1" maxOccurs="1">
  <entity>
    <simpleValue>IFCSLAB</simpleValue>
  </entity>
</partOf>
~~~

~~~lua
#1=IFCSLAB('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$);
#2=IFCBEAM('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$); /* Testcase */
#3=IFCRELAGGREGATES('05rScmOVzMoQXOfbYdtLYj',$,$,$,#1,(#2));
~~~

[Sample IDS](testcases/partof/pass-an_aggregate_may_specify_the_entity_of_the_whole_1_2.ids) - [Sample IFC: 2](testcases/partof/pass-an_aggregate_may_specify_the_entity_of_the_whole_1_2.ifc)

## [FAIL] An aggregate may specify the entity of the whole 2/2

~~~xml
<partOf relation="IfcRelAggregates" minOccurs="1" maxOccurs="1">
  <entity>
    <simpleValue>IFCWALL</simpleValue>
  </entity>
</partOf>
~~~

~~~lua
#1=IFCSLAB('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$);
#2=IFCBEAM('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$); /* Testcase */
#3=IFCRELAGGREGATES('05rScmOVzMoQXOfbYdtLYj',$,$,$,#1,(#2));
~~~

[Sample IDS](testcases/partof/fail-an_aggregate_may_specify_the_entity_of_the_whole_2_2.ids) - [Sample IFC: 2](testcases/partof/fail-an_aggregate_may_specify_the_entity_of_the_whole_2_2.ifc)

## [PASS] An aggregate entity may pass any ancestral whole passes

~~~xml
<partOf relation="IfcRelAggregates" minOccurs="1" maxOccurs="1">
  <entity>
    <simpleValue>IFCELEMENTASSEMBLY</simpleValue>
  </entity>
</partOf>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$,$);
#2=IFCSLAB('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$);
#3=IFCBEAM('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$); /* Testcase */
#4=IFCRELAGGREGATES('05rScmOVzMoQXOfbYdtLYj',$,$,$,#1,(#2));
#5=IFCRELAGGREGATES('05rScmOVzMoQXOfbYdtLYj',$,$,$,#2,(#3));
~~~

[Sample IDS](testcases/partof/pass-an_aggregate_entity_may_pass_any_ancestral_whole_passes.ids) - [Sample IFC: 3](testcases/partof/pass-an_aggregate_entity_may_pass_any_ancestral_whole_passes.ifc)

## [FAIL] A non grouped element fails a group relationship

~~~xml
<partOf relation="IfcRelAssignsToGroup" minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('0BbkGoC6vPvRW13UT7D8zH',$,$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCGROUP('0BbkGoC6vPvRW13UT7D8zH',$,'Unnamed','',$);
~~~

[Sample IDS](testcases/partof/fail-a_non_grouped_element_fails_a_group_relationship.ids) - [Sample IFC: 1](testcases/partof/fail-a_non_grouped_element_fails_a_group_relationship.ifc)

## [PASS] A grouped element passes a group relationship

~~~xml
<partOf relation="IfcRelAssignsToGroup" minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('0BbkGoC6vPvRW13UT7D8zH',$,$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCGROUP('0BbkGoC6vPvRW13UT7D8zH',$,'Unnamed','',$);
#3=IFCRELASSIGNSTOGROUP('0eA6m4fELI9QBIhP3wiLAp',$,$,$,(#1),$,#2);
~~~

[Sample IDS](testcases/partof/pass-a_grouped_element_passes_a_group_relationship.ids) - [Sample IFC: 1](testcases/partof/pass-a_grouped_element_passes_a_group_relationship.ifc)

## [FAIL] A group entity must match exactly 1/2

~~~xml
<partOf relation="IfcRelAssignsToGroup" minOccurs="1" maxOccurs="1">
  <entity>
    <simpleValue>IFCGROUP</simpleValue>
  </entity>
</partOf>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCINVENTORY('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$,$,$);
#3=IFCRELASSIGNSTOGROUP('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),$,#2);
~~~

[Sample IDS](testcases/partof/fail-a_group_entity_must_match_exactly_1_2.ids) - [Sample IFC: 1](testcases/partof/fail-a_group_entity_must_match_exactly_1_2.ifc)

## [PASS] A group entity must match exactly 2/2

~~~xml
<partOf relation="IfcRelAssignsToGroup" minOccurs="1" maxOccurs="1">
  <entity>
    <simpleValue>IFCINVENTORY</simpleValue>
  </entity>
</partOf>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCINVENTORY('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$,$,$);
#3=IFCRELASSIGNSTOGROUP('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),$,#2);
~~~

[Sample IDS](testcases/partof/pass-a_group_entity_must_match_exactly_2_2.ids) - [Sample IFC: 1](testcases/partof/pass-a_group_entity_must_match_exactly_2_2.ifc)

## [FAIL] Any contained element passes a containment relationship 1/2

~~~xml
<partOf relation="IfcRelContainedInSpatialStructure" minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCSPACE('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$,$,$);
~~~

[Sample IDS](testcases/partof/fail-any_contained_element_passes_a_containment_relationship_1_2.ids) - [Sample IFC: 1](testcases/partof/fail-any_contained_element_passes_a_containment_relationship_1_2.ifc)

## [PASS] Any contained element passes a containment relationship 2/2

~~~xml
<partOf relation="IfcRelContainedInSpatialStructure" minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCSPACE('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$,$,$);
#3=IFCRELCONTAINEDINSPATIALSTRUCTURE('0eA6m4fELI9QBIhP3wiLAp',$,$,$,(#1),#2);
~~~

[Sample IDS](testcases/partof/pass-any_contained_element_passes_a_containment_relationship_2_2.ids) - [Sample IFC: 1](testcases/partof/pass-any_contained_element_passes_a_containment_relationship_2_2.ifc)

## [FAIL] The container itself always fails

~~~xml
<partOf relation="IfcRelContainedInSpatialStructure" minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$,$);
#2=IFCSPACE('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$,$,$); /* Testcase */
#3=IFCRELCONTAINEDINSPATIALSTRUCTURE('0eA6m4fELI9QBIhP3wiLAp',$,$,$,(#1),#2);
~~~

[Sample IDS](testcases/partof/fail-the_container_itself_always_fails.ids) - [Sample IFC: 2](testcases/partof/fail-the_container_itself_always_fails.ifc)

## [FAIL] The container entity must match exactly 1/2

~~~xml
<partOf relation="IfcRelContainedInSpatialStructure" minOccurs="1" maxOccurs="1">
  <entity>
    <simpleValue>IFCSITE</simpleValue>
  </entity>
</partOf>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCSPACE('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$,$,$);
#3=IFCRELCONTAINEDINSPATIALSTRUCTURE('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
~~~

[Sample IDS](testcases/partof/fail-the_container_entity_must_match_exactly_1_2.ids) - [Sample IFC: 1](testcases/partof/fail-the_container_entity_must_match_exactly_1_2.ifc)

## [PASS] The container entity must match exactly 2/2

~~~xml
<partOf relation="IfcRelContainedInSpatialStructure" minOccurs="1" maxOccurs="1">
  <entity>
    <simpleValue>IFCSPACE</simpleValue>
  </entity>
</partOf>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCSPACE('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$,$,$);
#3=IFCRELCONTAINEDINSPATIALSTRUCTURE('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
~~~

[Sample IDS](testcases/partof/pass-the_container_entity_must_match_exactly_2_2.ids) - [Sample IFC: 1](testcases/partof/pass-the_container_entity_must_match_exactly_2_2.ifc)

## [PASS] The container may be indirect

~~~xml
<partOf relation="IfcRelContainedInSpatialStructure" minOccurs="1" maxOccurs="1">
  <entity>
    <simpleValue>IFCSPACE</simpleValue>
  </entity>
</partOf>
~~~

~~~lua
#1=IFCSLAB('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$);
#2=IFCBEAM('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$); /* Testcase */
#3=IFCRELAGGREGATES('05rScmOVzMoQXOfbYdtLYj',$,$,$,#1,(#2));
#4=IFCSPACE('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$,$,$);
#5=IFCRELCONTAINEDINSPATIALSTRUCTURE('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#4);
~~~

[Sample IDS](testcases/partof/pass-the_container_may_be_indirect.ids) - [Sample IFC: 2](testcases/partof/pass-the_container_may_be_indirect.ifc)

## [PASS] Any nested part passes a nest relationship

~~~xml
<partOf relation="IfcRelNests" minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCFURNITURE('0BbkGoC6vPvRW13UT7D8zH',$,$,$,$,$,$,$,$);
#2=IFCDISCRETEACCESSORY('0BbkGoC6vPvRW13UT7D8zH',$,$,$,$,$,$,$,$); /* Testcase */
#3=IFCRELNESTS('0BbkGoC6vPvRW13UT7D8zH',$,$,$,#1,(#2));
~~~

[Sample IDS](testcases/partof/pass-any_nested_part_passes_a_nest_relationship.ids) - [Sample IFC: 2](testcases/partof/pass-any_nested_part_passes_a_nest_relationship.ifc)

## [FAIL] Any nested whole fails a nest relationship

~~~xml
<partOf relation="IfcRelNests" minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCFURNITURE('0BbkGoC6vPvRW13UT7D8zH',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCDISCRETEACCESSORY('0BbkGoC6vPvRW13UT7D8zH',$,$,$,$,$,$,$,$);
#3=IFCRELNESTS('0BbkGoC6vPvRW13UT7D8zH',$,$,$,#1,(#2));
~~~

[Sample IDS](testcases/partof/fail-any_nested_whole_fails_a_nest_relationship.ids) - [Sample IFC: 1](testcases/partof/fail-any_nested_whole_fails_a_nest_relationship.ifc)

## [FAIL] The nest entity must match exactly 1/2

~~~xml
<partOf relation="IfcRelNests" minOccurs="1" maxOccurs="1">
  <entity>
    <simpleValue>IFCBEAM</simpleValue>
  </entity>
</partOf>
~~~

~~~lua
#1=IFCFURNITURE('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$);
#2=IFCDISCRETEACCESSORY('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$); /* Testcase */
#3=IFCRELNESTS('05rScmOVzMoQXOfbYdtLYj',$,$,$,#1,(#2));
~~~

[Sample IDS](testcases/partof/fail-the_nest_entity_must_match_exactly_1_2.ids) - [Sample IFC: 2](testcases/partof/fail-the_nest_entity_must_match_exactly_1_2.ifc)

## [PASS] The nest entity must match exactly 2/2

~~~xml
<partOf relation="IfcRelNests" minOccurs="1" maxOccurs="1">
  <entity>
    <simpleValue>IFCFURNITURE</simpleValue>
  </entity>
</partOf>
~~~

~~~lua
#1=IFCFURNITURE('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$);
#2=IFCDISCRETEACCESSORY('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$); /* Testcase */
#3=IFCRELNESTS('05rScmOVzMoQXOfbYdtLYj',$,$,$,#1,(#2));
~~~

[Sample IDS](testcases/partof/pass-the_nest_entity_must_match_exactly_2_2.ids) - [Sample IFC: 2](testcases/partof/pass-the_nest_entity_must_match_exactly_2_2.ifc)

## [PASS] Nesting may be indirect

~~~xml
<partOf relation="IfcRelNests" minOccurs="1" maxOccurs="1">
  <entity>
    <simpleValue>IFCFURNITURE</simpleValue>
  </entity>
</partOf>
~~~

~~~lua
#1=IFCFURNITURE('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$);
#2=IFCDISCRETEACCESSORY('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$);
#3=IFCMECHANICALFASTENER('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$,$,$); /* Testcase */
#4=IFCRELNESTS('05rScmOVzMoQXOfbYdtLYj',$,$,$,#1,(#2));
#5=IFCRELNESTS('05rScmOVzMoQXOfbYdtLYj',$,$,$,#2,(#3));
~~~

[Sample IDS](testcases/partof/pass-nesting_may_be_indirect.ids) - [Sample IFC: 3](testcases/partof/pass-nesting_may_be_indirect.ifc)


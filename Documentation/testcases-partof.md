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
#1=IFCELEMENTASSEMBLY('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('0eA6m4fELI9QBIhP3wiLAp',$,$,$,#1,(#2));
#4=IFCSLAB('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$);
#5=IFCBEAM('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$); /* Testcase */
#6=IFCRELAGGREGATES('0BbkGoC6vPvRW13UT7D8zH',$,$,$,#4,(#5));
~~~

[Sample IDS](testcases/partof/pass-an_aggregate_may_specify_the_entity_of_the_whole_1_2.ids) - [Sample IFC: 5](testcases/partof/pass-an_aggregate_may_specify_the_entity_of_the_whole_1_2.ifc)

## [FAIL] An aggregate may specify the entity of the whole 2/2

~~~xml
<partOf relation="IfcRelAggregates" minOccurs="1" maxOccurs="1">
  <entity>
    <simpleValue>IFCWALL</simpleValue>
  </entity>
</partOf>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('0eA6m4fELI9QBIhP3wiLAp',$,$,$,#1,(#2));
#4=IFCSLAB('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$);
#5=IFCBEAM('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$); /* Testcase */
#6=IFCRELAGGREGATES('0BbkGoC6vPvRW13UT7D8zH',$,$,$,#4,(#5));
~~~

[Sample IDS](testcases/partof/fail-an_aggregate_may_specify_the_entity_of_the_whole_2_2.ids) - [Sample IFC: 5](testcases/partof/fail-an_aggregate_may_specify_the_entity_of_the_whole_2_2.ifc)

## [PASS] An aggregate entity may pass any ancestral whole passes

~~~xml
<partOf relation="IfcRelAggregates" minOccurs="1" maxOccurs="1">
  <entity>
    <simpleValue>IFCELEMENTASSEMBLY</simpleValue>
  </entity>
</partOf>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('0eA6m4fELI9QBIhP3wiLAp',$,$,$,#1,(#2));
#4=IFCSLAB('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$);
#5=IFCBEAM('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#6=IFCRELAGGREGATES('0BbkGoC6vPvRW13UT7D8zH',$,$,$,#4,(#5));
#7=IFCELEMENTASSEMBLY('3dn5FxJ$bKte8lL5dru6xn',$,$,$,$,$,$,$,$,$);
#8=IFCSLAB('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#9=IFCBEAM('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$); /* Testcase */
#10=IFCRELAGGREGATES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,#7,(#8));
#11=IFCRELAGGREGATES('0WTUhjMwvT39YBFH2pryoM',$,$,$,#8,(#9));
~~~

[Sample IDS](testcases/partof/pass-an_aggregate_entity_may_pass_any_ancestral_whole_passes.ids) - [Sample IFC: 9](testcases/partof/pass-an_aggregate_entity_may_pass_any_ancestral_whole_passes.ifc)

## [FAIL] A non grouped element fails a group relationship

~~~xml
<partOf relation="IfcRelAssignsToGroup" minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('0eA6m4fELI9QBIhP3wiLAp',$,$,$,#1,(#2));
#4=IFCSLAB('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$);
#5=IFCBEAM('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#6=IFCRELAGGREGATES('0BbkGoC6vPvRW13UT7D8zH',$,$,$,#4,(#5));
#7=IFCELEMENTASSEMBLY('3dn5FxJ$bKte8lL5dru6xn',$,$,$,$,$,$,$,$,$);
#8=IFCSLAB('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#9=IFCBEAM('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#10=IFCRELAGGREGATES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,#7,(#8));
#11=IFCRELAGGREGATES('0WTUhjMwvT39YBFH2pryoM',$,$,$,#8,(#9));
#12=IFCELEMENTASSEMBLY('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$,$); /* Testcase */
#13=IFCGROUP('3b0AoFivPN6RDJO6UL_GfZ',$,'Unnamed','',$);
~~~

[Sample IDS](testcases/partof/fail-a_non_grouped_element_fails_a_group_relationship.ids) - [Sample IFC: 12](testcases/partof/fail-a_non_grouped_element_fails_a_group_relationship.ifc)

## [PASS] A grouped element passes a group relationship

~~~xml
<partOf relation="IfcRelAssignsToGroup" minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('0eA6m4fELI9QBIhP3wiLAp',$,$,$,#1,(#2));
#4=IFCSLAB('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$);
#5=IFCBEAM('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#6=IFCRELAGGREGATES('0BbkGoC6vPvRW13UT7D8zH',$,$,$,#4,(#5));
#7=IFCELEMENTASSEMBLY('3dn5FxJ$bKte8lL5dru6xn',$,$,$,$,$,$,$,$,$);
#8=IFCSLAB('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#9=IFCBEAM('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#10=IFCRELAGGREGATES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,#7,(#8));
#11=IFCRELAGGREGATES('0WTUhjMwvT39YBFH2pryoM',$,$,$,#8,(#9));
#12=IFCELEMENTASSEMBLY('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$,$); /* Testcase */
#13=IFCGROUP('3b0AoFivPN6RDJO6UL_GfZ',$,'Unnamed','',$);
#14=IFCRELASSIGNSTOGROUP('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),$,#13);
~~~

[Sample IDS](testcases/partof/pass-a_grouped_element_passes_a_group_relationship.ids) - [Sample IFC: 12](testcases/partof/pass-a_grouped_element_passes_a_group_relationship.ifc)

## [FAIL] A group entity must match exactly 1/2

~~~xml
<partOf relation="IfcRelAssignsToGroup" minOccurs="1" maxOccurs="1">
  <entity>
    <simpleValue>IFCGROUP</simpleValue>
  </entity>
</partOf>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('0eA6m4fELI9QBIhP3wiLAp',$,$,$,#1,(#2));
#4=IFCSLAB('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$);
#5=IFCBEAM('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#6=IFCRELAGGREGATES('0BbkGoC6vPvRW13UT7D8zH',$,$,$,#4,(#5));
#7=IFCELEMENTASSEMBLY('3dn5FxJ$bKte8lL5dru6xn',$,$,$,$,$,$,$,$,$);
#8=IFCSLAB('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#9=IFCBEAM('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#10=IFCRELAGGREGATES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,#7,(#8));
#11=IFCRELAGGREGATES('0WTUhjMwvT39YBFH2pryoM',$,$,$,#8,(#9));
#12=IFCELEMENTASSEMBLY('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$,$);
#13=IFCGROUP('3b0AoFivPN6RDJO6UL_GfZ',$,'Unnamed','',$);
#14=IFCRELASSIGNSTOGROUP('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),$,#13);
#15=IFCELEMENTASSEMBLY('0zOgnThXbJ18CK0JKHikvt',$,$,$,$,$,$,$,$,$); /* Testcase */
#16=IFCINVENTORY('3CEylLjX9L0huf3t4LJMIA',$,$,$,$,$,$,$,$,$,$);
#17=IFCRELASSIGNSTOGROUP('1X7Mz0AZrMOPkukNM5XTEV',$,$,$,(#15),$,#16);
~~~

[Sample IDS](testcases/partof/fail-a_group_entity_must_match_exactly_1_2.ids) - [Sample IFC: 15](testcases/partof/fail-a_group_entity_must_match_exactly_1_2.ifc)

## [PASS] A group entity must match exactly 2/2

~~~xml
<partOf relation="IfcRelAssignsToGroup" minOccurs="1" maxOccurs="1">
  <entity>
    <simpleValue>IFCINVENTORY</simpleValue>
  </entity>
</partOf>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('0eA6m4fELI9QBIhP3wiLAp',$,$,$,#1,(#2));
#4=IFCSLAB('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$);
#5=IFCBEAM('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#6=IFCRELAGGREGATES('0BbkGoC6vPvRW13UT7D8zH',$,$,$,#4,(#5));
#7=IFCELEMENTASSEMBLY('3dn5FxJ$bKte8lL5dru6xn',$,$,$,$,$,$,$,$,$);
#8=IFCSLAB('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#9=IFCBEAM('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#10=IFCRELAGGREGATES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,#7,(#8));
#11=IFCRELAGGREGATES('0WTUhjMwvT39YBFH2pryoM',$,$,$,#8,(#9));
#12=IFCELEMENTASSEMBLY('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$,$);
#13=IFCGROUP('3b0AoFivPN6RDJO6UL_GfZ',$,'Unnamed','',$);
#14=IFCRELASSIGNSTOGROUP('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),$,#13);
#15=IFCELEMENTASSEMBLY('0zOgnThXbJ18CK0JKHikvt',$,$,$,$,$,$,$,$,$); /* Testcase */
#16=IFCINVENTORY('3CEylLjX9L0huf3t4LJMIA',$,$,$,$,$,$,$,$,$,$);
#17=IFCRELASSIGNSTOGROUP('1X7Mz0AZrMOPkukNM5XTEV',$,$,$,(#15),$,#16);
~~~

[Sample IDS](testcases/partof/pass-a_group_entity_must_match_exactly_2_2.ids) - [Sample IFC: 15](testcases/partof/pass-a_group_entity_must_match_exactly_2_2.ifc)

## [FAIL] Any contained element passes a containment relationship 1/2

~~~xml
<partOf relation="IfcRelContainedInSpatialStructure" minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('0eA6m4fELI9QBIhP3wiLAp',$,$,$,#1,(#2));
#4=IFCSLAB('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$);
#5=IFCBEAM('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#6=IFCRELAGGREGATES('0BbkGoC6vPvRW13UT7D8zH',$,$,$,#4,(#5));
#7=IFCELEMENTASSEMBLY('3dn5FxJ$bKte8lL5dru6xn',$,$,$,$,$,$,$,$,$);
#8=IFCSLAB('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#9=IFCBEAM('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#10=IFCRELAGGREGATES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,#7,(#8));
#11=IFCRELAGGREGATES('0WTUhjMwvT39YBFH2pryoM',$,$,$,#8,(#9));
#12=IFCELEMENTASSEMBLY('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$,$);
#13=IFCGROUP('3b0AoFivPN6RDJO6UL_GfZ',$,'Unnamed','',$);
#14=IFCRELASSIGNSTOGROUP('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),$,#13);
#15=IFCELEMENTASSEMBLY('0zOgnThXbJ18CK0JKHikvt',$,$,$,$,$,$,$,$,$);
#16=IFCINVENTORY('3CEylLjX9L0huf3t4LJMIA',$,$,$,$,$,$,$,$,$,$);
#17=IFCRELASSIGNSTOGROUP('1X7Mz0AZrMOPkukNM5XTEV',$,$,$,(#15),$,#16);
#18=IFCELEMENTASSEMBLY('3CEylLjX9L0huf3t4LJMIA',$,$,$,$,$,$,$,$,$); /* Testcase */
#19=IFCSPACE('3qs_CEYznSwfyPnfvmY$jn',$,$,$,$,$,$,$,$,$,$);
~~~

[Sample IDS](testcases/partof/fail-any_contained_element_passes_a_containment_relationship_1_2.ids) - [Sample IFC: 18](testcases/partof/fail-any_contained_element_passes_a_containment_relationship_1_2.ifc)

## [PASS] Any contained element passes a containment relationship 2/2

~~~xml
<partOf relation="IfcRelContainedInSpatialStructure" minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('0eA6m4fELI9QBIhP3wiLAp',$,$,$,#1,(#2));
#4=IFCSLAB('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$);
#5=IFCBEAM('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#6=IFCRELAGGREGATES('0BbkGoC6vPvRW13UT7D8zH',$,$,$,#4,(#5));
#7=IFCELEMENTASSEMBLY('3dn5FxJ$bKte8lL5dru6xn',$,$,$,$,$,$,$,$,$);
#8=IFCSLAB('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#9=IFCBEAM('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#10=IFCRELAGGREGATES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,#7,(#8));
#11=IFCRELAGGREGATES('0WTUhjMwvT39YBFH2pryoM',$,$,$,#8,(#9));
#12=IFCELEMENTASSEMBLY('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$,$);
#13=IFCGROUP('3b0AoFivPN6RDJO6UL_GfZ',$,'Unnamed','',$);
#14=IFCRELASSIGNSTOGROUP('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),$,#13);
#15=IFCELEMENTASSEMBLY('0zOgnThXbJ18CK0JKHikvt',$,$,$,$,$,$,$,$,$);
#16=IFCINVENTORY('3CEylLjX9L0huf3t4LJMIA',$,$,$,$,$,$,$,$,$,$);
#17=IFCRELASSIGNSTOGROUP('1X7Mz0AZrMOPkukNM5XTEV',$,$,$,(#15),$,#16);
#18=IFCELEMENTASSEMBLY('3CEylLjX9L0huf3t4LJMIA',$,$,$,$,$,$,$,$,$); /* Testcase */
#19=IFCSPACE('3qs_CEYznSwfyPnfvmY$jn',$,$,$,$,$,$,$,$,$,$);
#20=IFCRELCONTAINEDINSPATIALSTRUCTURE('2J464n_AnPNgUfYvzrChAh',$,$,$,(#18),#19);
~~~

[Sample IDS](testcases/partof/pass-any_contained_element_passes_a_containment_relationship_2_2.ids) - [Sample IFC: 18](testcases/partof/pass-any_contained_element_passes_a_containment_relationship_2_2.ifc)

## [FAIL] The container itself always fails

~~~xml
<partOf relation="IfcRelContainedInSpatialStructure" minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('0eA6m4fELI9QBIhP3wiLAp',$,$,$,#1,(#2));
#4=IFCSLAB('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$);
#5=IFCBEAM('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#6=IFCRELAGGREGATES('0BbkGoC6vPvRW13UT7D8zH',$,$,$,#4,(#5));
#7=IFCELEMENTASSEMBLY('3dn5FxJ$bKte8lL5dru6xn',$,$,$,$,$,$,$,$,$);
#8=IFCSLAB('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#9=IFCBEAM('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#10=IFCRELAGGREGATES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,#7,(#8));
#11=IFCRELAGGREGATES('0WTUhjMwvT39YBFH2pryoM',$,$,$,#8,(#9));
#12=IFCELEMENTASSEMBLY('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$,$);
#13=IFCGROUP('3b0AoFivPN6RDJO6UL_GfZ',$,'Unnamed','',$);
#14=IFCRELASSIGNSTOGROUP('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),$,#13);
#15=IFCELEMENTASSEMBLY('0zOgnThXbJ18CK0JKHikvt',$,$,$,$,$,$,$,$,$);
#16=IFCINVENTORY('3CEylLjX9L0huf3t4LJMIA',$,$,$,$,$,$,$,$,$,$);
#17=IFCRELASSIGNSTOGROUP('1X7Mz0AZrMOPkukNM5XTEV',$,$,$,(#15),$,#16);
#18=IFCELEMENTASSEMBLY('3CEylLjX9L0huf3t4LJMIA',$,$,$,$,$,$,$,$,$);
#19=IFCSPACE('3qs_CEYznSwfyPnfvmY$jn',$,$,$,$,$,$,$,$,$,$); /* Testcase */
#20=IFCRELCONTAINEDINSPATIALSTRUCTURE('2J464n_AnPNgUfYvzrChAh',$,$,$,(#18),#19);
~~~

[Sample IDS](testcases/partof/fail-the_container_itself_always_fails.ids) - [Sample IFC: 19](testcases/partof/fail-the_container_itself_always_fails.ifc)

## [FAIL] The container entity must match exactly 1/2

~~~xml
<partOf relation="IfcRelContainedInSpatialStructure" minOccurs="1" maxOccurs="1">
  <entity>
    <simpleValue>IFCSITE</simpleValue>
  </entity>
</partOf>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('0eA6m4fELI9QBIhP3wiLAp',$,$,$,#1,(#2));
#4=IFCSLAB('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$);
#5=IFCBEAM('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#6=IFCRELAGGREGATES('0BbkGoC6vPvRW13UT7D8zH',$,$,$,#4,(#5));
#7=IFCELEMENTASSEMBLY('3dn5FxJ$bKte8lL5dru6xn',$,$,$,$,$,$,$,$,$);
#8=IFCSLAB('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#9=IFCBEAM('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#10=IFCRELAGGREGATES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,#7,(#8));
#11=IFCRELAGGREGATES('0WTUhjMwvT39YBFH2pryoM',$,$,$,#8,(#9));
#12=IFCELEMENTASSEMBLY('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$,$);
#13=IFCGROUP('3b0AoFivPN6RDJO6UL_GfZ',$,'Unnamed','',$);
#14=IFCRELASSIGNSTOGROUP('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),$,#13);
#15=IFCELEMENTASSEMBLY('0zOgnThXbJ18CK0JKHikvt',$,$,$,$,$,$,$,$,$);
#16=IFCINVENTORY('3CEylLjX9L0huf3t4LJMIA',$,$,$,$,$,$,$,$,$,$);
#17=IFCRELASSIGNSTOGROUP('1X7Mz0AZrMOPkukNM5XTEV',$,$,$,(#15),$,#16);
#18=IFCELEMENTASSEMBLY('3CEylLjX9L0huf3t4LJMIA',$,$,$,$,$,$,$,$,$);
#19=IFCSPACE('3qs_CEYznSwfyPnfvmY$jn',$,$,$,$,$,$,$,$,$,$);
#20=IFCRELCONTAINEDINSPATIALSTRUCTURE('2J464n_AnPNgUfYvzrChAh',$,$,$,(#18),#19);
#21=IFCELEMENTASSEMBLY('3NmyAazpzLq8cIG7JPLlM9',$,$,$,$,$,$,$,$,$); /* Testcase */
#22=IFCSPACE('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,$,$,$,$,$,$,$);
#23=IFCRELCONTAINEDINSPATIALSTRUCTURE('25g_sgGv1Ktw1yG4pu$Q5F',$,$,$,(#21),#22);
~~~

[Sample IDS](testcases/partof/fail-the_container_entity_must_match_exactly_1_2.ids) - [Sample IFC: 21](testcases/partof/fail-the_container_entity_must_match_exactly_1_2.ifc)

## [PASS] The container entity must match exactly 2/2

~~~xml
<partOf relation="IfcRelContainedInSpatialStructure" minOccurs="1" maxOccurs="1">
  <entity>
    <simpleValue>IFCSPACE</simpleValue>
  </entity>
</partOf>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('0eA6m4fELI9QBIhP3wiLAp',$,$,$,#1,(#2));
#4=IFCSLAB('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$);
#5=IFCBEAM('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#6=IFCRELAGGREGATES('0BbkGoC6vPvRW13UT7D8zH',$,$,$,#4,(#5));
#7=IFCELEMENTASSEMBLY('3dn5FxJ$bKte8lL5dru6xn',$,$,$,$,$,$,$,$,$);
#8=IFCSLAB('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#9=IFCBEAM('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#10=IFCRELAGGREGATES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,#7,(#8));
#11=IFCRELAGGREGATES('0WTUhjMwvT39YBFH2pryoM',$,$,$,#8,(#9));
#12=IFCELEMENTASSEMBLY('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$,$);
#13=IFCGROUP('3b0AoFivPN6RDJO6UL_GfZ',$,'Unnamed','',$);
#14=IFCRELASSIGNSTOGROUP('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),$,#13);
#15=IFCELEMENTASSEMBLY('0zOgnThXbJ18CK0JKHikvt',$,$,$,$,$,$,$,$,$);
#16=IFCINVENTORY('3CEylLjX9L0huf3t4LJMIA',$,$,$,$,$,$,$,$,$,$);
#17=IFCRELASSIGNSTOGROUP('1X7Mz0AZrMOPkukNM5XTEV',$,$,$,(#15),$,#16);
#18=IFCELEMENTASSEMBLY('3CEylLjX9L0huf3t4LJMIA',$,$,$,$,$,$,$,$,$);
#19=IFCSPACE('3qs_CEYznSwfyPnfvmY$jn',$,$,$,$,$,$,$,$,$,$);
#20=IFCRELCONTAINEDINSPATIALSTRUCTURE('2J464n_AnPNgUfYvzrChAh',$,$,$,(#18),#19);
#21=IFCELEMENTASSEMBLY('3NmyAazpzLq8cIG7JPLlM9',$,$,$,$,$,$,$,$,$); /* Testcase */
#22=IFCSPACE('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,$,$,$,$,$,$,$);
#23=IFCRELCONTAINEDINSPATIALSTRUCTURE('25g_sgGv1Ktw1yG4pu$Q5F',$,$,$,(#21),#22);
~~~

[Sample IDS](testcases/partof/pass-the_container_entity_must_match_exactly_2_2.ids) - [Sample IFC: 21](testcases/partof/pass-the_container_entity_must_match_exactly_2_2.ifc)

## [PASS] The container may be indirect

~~~xml
<partOf relation="IfcRelContainedInSpatialStructure" minOccurs="1" maxOccurs="1">
  <entity>
    <simpleValue>IFCSPACE</simpleValue>
  </entity>
</partOf>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('0eA6m4fELI9QBIhP3wiLAp',$,$,$,#1,(#2));
#4=IFCSLAB('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$);
#5=IFCBEAM('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#6=IFCRELAGGREGATES('0BbkGoC6vPvRW13UT7D8zH',$,$,$,#4,(#5));
#7=IFCELEMENTASSEMBLY('3dn5FxJ$bKte8lL5dru6xn',$,$,$,$,$,$,$,$,$);
#8=IFCSLAB('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#9=IFCBEAM('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#10=IFCRELAGGREGATES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,#7,(#8));
#11=IFCRELAGGREGATES('0WTUhjMwvT39YBFH2pryoM',$,$,$,#8,(#9));
#12=IFCELEMENTASSEMBLY('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$,$);
#13=IFCGROUP('3b0AoFivPN6RDJO6UL_GfZ',$,'Unnamed','',$);
#14=IFCRELASSIGNSTOGROUP('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),$,#13);
#15=IFCELEMENTASSEMBLY('0zOgnThXbJ18CK0JKHikvt',$,$,$,$,$,$,$,$,$);
#16=IFCINVENTORY('3CEylLjX9L0huf3t4LJMIA',$,$,$,$,$,$,$,$,$,$);
#17=IFCRELASSIGNSTOGROUP('1X7Mz0AZrMOPkukNM5XTEV',$,$,$,(#15),$,#16);
#18=IFCELEMENTASSEMBLY('3CEylLjX9L0huf3t4LJMIA',$,$,$,$,$,$,$,$,$);
#19=IFCSPACE('3qs_CEYznSwfyPnfvmY$jn',$,$,$,$,$,$,$,$,$,$);
#20=IFCRELCONTAINEDINSPATIALSTRUCTURE('2J464n_AnPNgUfYvzrChAh',$,$,$,(#18),#19);
#21=IFCELEMENTASSEMBLY('3NmyAazpzLq8cIG7JPLlM9',$,$,$,$,$,$,$,$,$);
#22=IFCSPACE('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,$,$,$,$,$,$,$);
#23=IFCRELCONTAINEDINSPATIALSTRUCTURE('25g_sgGv1Ktw1yG4pu$Q5F',$,$,$,(#21),#22);
#24=IFCSLAB('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCBEAM('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$); /* Testcase */
#26=IFCRELAGGREGATES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,#24,(#25));
#27=IFCSPACE('1$n1_2RkXPbfXO7oow3KlU',$,$,$,$,$,$,$,$,$,$);
#28=IFCRELCONTAINEDINSPATIALSTRUCTURE('0aEFdeguTItxk11mFwy_RG',$,$,$,(#24),#27);
~~~

[Sample IDS](testcases/partof/pass-the_container_may_be_indirect.ids) - [Sample IFC: 25](testcases/partof/pass-the_container_may_be_indirect.ifc)

## [PASS] Any nested part passes a nest relationship

~~~xml
<partOf relation="IfcRelNests" minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('0eA6m4fELI9QBIhP3wiLAp',$,$,$,#1,(#2));
#4=IFCSLAB('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$);
#5=IFCBEAM('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#6=IFCRELAGGREGATES('0BbkGoC6vPvRW13UT7D8zH',$,$,$,#4,(#5));
#7=IFCELEMENTASSEMBLY('3dn5FxJ$bKte8lL5dru6xn',$,$,$,$,$,$,$,$,$);
#8=IFCSLAB('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#9=IFCBEAM('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#10=IFCRELAGGREGATES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,#7,(#8));
#11=IFCRELAGGREGATES('0WTUhjMwvT39YBFH2pryoM',$,$,$,#8,(#9));
#12=IFCELEMENTASSEMBLY('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$,$);
#13=IFCGROUP('3b0AoFivPN6RDJO6UL_GfZ',$,'Unnamed','',$);
#14=IFCRELASSIGNSTOGROUP('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),$,#13);
#15=IFCELEMENTASSEMBLY('0zOgnThXbJ18CK0JKHikvt',$,$,$,$,$,$,$,$,$);
#16=IFCINVENTORY('3CEylLjX9L0huf3t4LJMIA',$,$,$,$,$,$,$,$,$,$);
#17=IFCRELASSIGNSTOGROUP('1X7Mz0AZrMOPkukNM5XTEV',$,$,$,(#15),$,#16);
#18=IFCELEMENTASSEMBLY('3CEylLjX9L0huf3t4LJMIA',$,$,$,$,$,$,$,$,$);
#19=IFCSPACE('3qs_CEYznSwfyPnfvmY$jn',$,$,$,$,$,$,$,$,$,$);
#20=IFCRELCONTAINEDINSPATIALSTRUCTURE('2J464n_AnPNgUfYvzrChAh',$,$,$,(#18),#19);
#21=IFCELEMENTASSEMBLY('3NmyAazpzLq8cIG7JPLlM9',$,$,$,$,$,$,$,$,$);
#22=IFCSPACE('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,$,$,$,$,$,$,$);
#23=IFCRELCONTAINEDINSPATIALSTRUCTURE('25g_sgGv1Ktw1yG4pu$Q5F',$,$,$,(#21),#22);
#24=IFCSLAB('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCBEAM('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#26=IFCRELAGGREGATES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,#24,(#25));
#27=IFCSPACE('1$n1_2RkXPbfXO7oow3KlU',$,$,$,$,$,$,$,$,$,$);
#28=IFCRELCONTAINEDINSPATIALSTRUCTURE('0aEFdeguTItxk11mFwy_RG',$,$,$,(#24),#27);
#29=IFCFURNITURE('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCDISCRETEACCESSORY('2wP8lRhDTKrxIPJKeaifuL',$,$,$,$,$,$,$,$); /* Testcase */
#31=IFCRELNESTS('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,#29,(#30));
~~~

[Sample IDS](testcases/partof/pass-any_nested_part_passes_a_nest_relationship.ids) - [Sample IFC: 30](testcases/partof/pass-any_nested_part_passes_a_nest_relationship.ifc)

## [FAIL] Any nested whole fails a nest relationship

~~~xml
<partOf relation="IfcRelNests" minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('0eA6m4fELI9QBIhP3wiLAp',$,$,$,#1,(#2));
#4=IFCSLAB('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$);
#5=IFCBEAM('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#6=IFCRELAGGREGATES('0BbkGoC6vPvRW13UT7D8zH',$,$,$,#4,(#5));
#7=IFCELEMENTASSEMBLY('3dn5FxJ$bKte8lL5dru6xn',$,$,$,$,$,$,$,$,$);
#8=IFCSLAB('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#9=IFCBEAM('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#10=IFCRELAGGREGATES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,#7,(#8));
#11=IFCRELAGGREGATES('0WTUhjMwvT39YBFH2pryoM',$,$,$,#8,(#9));
#12=IFCELEMENTASSEMBLY('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$,$);
#13=IFCGROUP('3b0AoFivPN6RDJO6UL_GfZ',$,'Unnamed','',$);
#14=IFCRELASSIGNSTOGROUP('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),$,#13);
#15=IFCELEMENTASSEMBLY('0zOgnThXbJ18CK0JKHikvt',$,$,$,$,$,$,$,$,$);
#16=IFCINVENTORY('3CEylLjX9L0huf3t4LJMIA',$,$,$,$,$,$,$,$,$,$);
#17=IFCRELASSIGNSTOGROUP('1X7Mz0AZrMOPkukNM5XTEV',$,$,$,(#15),$,#16);
#18=IFCELEMENTASSEMBLY('3CEylLjX9L0huf3t4LJMIA',$,$,$,$,$,$,$,$,$);
#19=IFCSPACE('3qs_CEYznSwfyPnfvmY$jn',$,$,$,$,$,$,$,$,$,$);
#20=IFCRELCONTAINEDINSPATIALSTRUCTURE('2J464n_AnPNgUfYvzrChAh',$,$,$,(#18),#19);
#21=IFCELEMENTASSEMBLY('3NmyAazpzLq8cIG7JPLlM9',$,$,$,$,$,$,$,$,$);
#22=IFCSPACE('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,$,$,$,$,$,$,$);
#23=IFCRELCONTAINEDINSPATIALSTRUCTURE('25g_sgGv1Ktw1yG4pu$Q5F',$,$,$,(#21),#22);
#24=IFCSLAB('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCBEAM('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#26=IFCRELAGGREGATES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,#24,(#25));
#27=IFCSPACE('1$n1_2RkXPbfXO7oow3KlU',$,$,$,$,$,$,$,$,$,$);
#28=IFCRELCONTAINEDINSPATIALSTRUCTURE('0aEFdeguTItxk11mFwy_RG',$,$,$,(#24),#27);
#29=IFCFURNITURE('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$); /* Testcase */
#30=IFCDISCRETEACCESSORY('2wP8lRhDTKrxIPJKeaifuL',$,$,$,$,$,$,$,$);
#31=IFCRELNESTS('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,#29,(#30));
~~~

[Sample IDS](testcases/partof/fail-any_nested_whole_fails_a_nest_relationship.ids) - [Sample IFC: 29](testcases/partof/fail-any_nested_whole_fails_a_nest_relationship.ifc)

## [FAIL] The nest entity must match exactly 1/2

~~~xml
<partOf relation="IfcRelNests" minOccurs="1" maxOccurs="1">
  <entity>
    <simpleValue>IFCBEAM</simpleValue>
  </entity>
</partOf>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('0eA6m4fELI9QBIhP3wiLAp',$,$,$,#1,(#2));
#4=IFCSLAB('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$);
#5=IFCBEAM('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#6=IFCRELAGGREGATES('0BbkGoC6vPvRW13UT7D8zH',$,$,$,#4,(#5));
#7=IFCELEMENTASSEMBLY('3dn5FxJ$bKte8lL5dru6xn',$,$,$,$,$,$,$,$,$);
#8=IFCSLAB('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#9=IFCBEAM('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#10=IFCRELAGGREGATES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,#7,(#8));
#11=IFCRELAGGREGATES('0WTUhjMwvT39YBFH2pryoM',$,$,$,#8,(#9));
#12=IFCELEMENTASSEMBLY('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$,$);
#13=IFCGROUP('3b0AoFivPN6RDJO6UL_GfZ',$,'Unnamed','',$);
#14=IFCRELASSIGNSTOGROUP('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),$,#13);
#15=IFCELEMENTASSEMBLY('0zOgnThXbJ18CK0JKHikvt',$,$,$,$,$,$,$,$,$);
#16=IFCINVENTORY('3CEylLjX9L0huf3t4LJMIA',$,$,$,$,$,$,$,$,$,$);
#17=IFCRELASSIGNSTOGROUP('1X7Mz0AZrMOPkukNM5XTEV',$,$,$,(#15),$,#16);
#18=IFCELEMENTASSEMBLY('3CEylLjX9L0huf3t4LJMIA',$,$,$,$,$,$,$,$,$);
#19=IFCSPACE('3qs_CEYznSwfyPnfvmY$jn',$,$,$,$,$,$,$,$,$,$);
#20=IFCRELCONTAINEDINSPATIALSTRUCTURE('2J464n_AnPNgUfYvzrChAh',$,$,$,(#18),#19);
#21=IFCELEMENTASSEMBLY('3NmyAazpzLq8cIG7JPLlM9',$,$,$,$,$,$,$,$,$);
#22=IFCSPACE('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,$,$,$,$,$,$,$);
#23=IFCRELCONTAINEDINSPATIALSTRUCTURE('25g_sgGv1Ktw1yG4pu$Q5F',$,$,$,(#21),#22);
#24=IFCSLAB('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCBEAM('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#26=IFCRELAGGREGATES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,#24,(#25));
#27=IFCSPACE('1$n1_2RkXPbfXO7oow3KlU',$,$,$,$,$,$,$,$,$,$);
#28=IFCRELCONTAINEDINSPATIALSTRUCTURE('0aEFdeguTItxk11mFwy_RG',$,$,$,(#24),#27);
#29=IFCFURNITURE('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCDISCRETEACCESSORY('2wP8lRhDTKrxIPJKeaifuL',$,$,$,$,$,$,$,$);
#31=IFCRELNESTS('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,#29,(#30));
#32=IFCFURNITURE('0nB_kaOvDG6eluiK84kq9M',$,$,$,$,$,$,$,$);
#33=IFCDISCRETEACCESSORY('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$); /* Testcase */
#34=IFCRELNESTS('2cohnZTsfUgQK$4UvlhCtt',$,$,$,#32,(#33));
~~~

[Sample IDS](testcases/partof/fail-the_nest_entity_must_match_exactly_1_2.ids) - [Sample IFC: 33](testcases/partof/fail-the_nest_entity_must_match_exactly_1_2.ifc)

## [PASS] The nest entity must match exactly 2/2

~~~xml
<partOf relation="IfcRelNests" minOccurs="1" maxOccurs="1">
  <entity>
    <simpleValue>IFCFURNITURE</simpleValue>
  </entity>
</partOf>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('0eA6m4fELI9QBIhP3wiLAp',$,$,$,#1,(#2));
#4=IFCSLAB('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$);
#5=IFCBEAM('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#6=IFCRELAGGREGATES('0BbkGoC6vPvRW13UT7D8zH',$,$,$,#4,(#5));
#7=IFCELEMENTASSEMBLY('3dn5FxJ$bKte8lL5dru6xn',$,$,$,$,$,$,$,$,$);
#8=IFCSLAB('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#9=IFCBEAM('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#10=IFCRELAGGREGATES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,#7,(#8));
#11=IFCRELAGGREGATES('0WTUhjMwvT39YBFH2pryoM',$,$,$,#8,(#9));
#12=IFCELEMENTASSEMBLY('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$,$);
#13=IFCGROUP('3b0AoFivPN6RDJO6UL_GfZ',$,'Unnamed','',$);
#14=IFCRELASSIGNSTOGROUP('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),$,#13);
#15=IFCELEMENTASSEMBLY('0zOgnThXbJ18CK0JKHikvt',$,$,$,$,$,$,$,$,$);
#16=IFCINVENTORY('3CEylLjX9L0huf3t4LJMIA',$,$,$,$,$,$,$,$,$,$);
#17=IFCRELASSIGNSTOGROUP('1X7Mz0AZrMOPkukNM5XTEV',$,$,$,(#15),$,#16);
#18=IFCELEMENTASSEMBLY('3CEylLjX9L0huf3t4LJMIA',$,$,$,$,$,$,$,$,$);
#19=IFCSPACE('3qs_CEYznSwfyPnfvmY$jn',$,$,$,$,$,$,$,$,$,$);
#20=IFCRELCONTAINEDINSPATIALSTRUCTURE('2J464n_AnPNgUfYvzrChAh',$,$,$,(#18),#19);
#21=IFCELEMENTASSEMBLY('3NmyAazpzLq8cIG7JPLlM9',$,$,$,$,$,$,$,$,$);
#22=IFCSPACE('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,$,$,$,$,$,$,$);
#23=IFCRELCONTAINEDINSPATIALSTRUCTURE('25g_sgGv1Ktw1yG4pu$Q5F',$,$,$,(#21),#22);
#24=IFCSLAB('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCBEAM('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#26=IFCRELAGGREGATES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,#24,(#25));
#27=IFCSPACE('1$n1_2RkXPbfXO7oow3KlU',$,$,$,$,$,$,$,$,$,$);
#28=IFCRELCONTAINEDINSPATIALSTRUCTURE('0aEFdeguTItxk11mFwy_RG',$,$,$,(#24),#27);
#29=IFCFURNITURE('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCDISCRETEACCESSORY('2wP8lRhDTKrxIPJKeaifuL',$,$,$,$,$,$,$,$);
#31=IFCRELNESTS('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,#29,(#30));
#32=IFCFURNITURE('0nB_kaOvDG6eluiK84kq9M',$,$,$,$,$,$,$,$);
#33=IFCDISCRETEACCESSORY('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$); /* Testcase */
#34=IFCRELNESTS('2cohnZTsfUgQK$4UvlhCtt',$,$,$,#32,(#33));
~~~

[Sample IDS](testcases/partof/pass-the_nest_entity_must_match_exactly_2_2.ids) - [Sample IFC: 33](testcases/partof/pass-the_nest_entity_must_match_exactly_2_2.ifc)

## [PASS] Nesting may be indirect

~~~xml
<partOf relation="IfcRelNests" minOccurs="1" maxOccurs="1">
  <entity>
    <simpleValue>IFCFURNITURE</simpleValue>
  </entity>
</partOf>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('0eA6m4fELI9QBIhP3wiLAp',$,$,$,#1,(#2));
#4=IFCSLAB('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$);
#5=IFCBEAM('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#6=IFCRELAGGREGATES('0BbkGoC6vPvRW13UT7D8zH',$,$,$,#4,(#5));
#7=IFCELEMENTASSEMBLY('3dn5FxJ$bKte8lL5dru6xn',$,$,$,$,$,$,$,$,$);
#8=IFCSLAB('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#9=IFCBEAM('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#10=IFCRELAGGREGATES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,#7,(#8));
#11=IFCRELAGGREGATES('0WTUhjMwvT39YBFH2pryoM',$,$,$,#8,(#9));
#12=IFCELEMENTASSEMBLY('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$,$);
#13=IFCGROUP('3b0AoFivPN6RDJO6UL_GfZ',$,'Unnamed','',$);
#14=IFCRELASSIGNSTOGROUP('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),$,#13);
#15=IFCELEMENTASSEMBLY('0zOgnThXbJ18CK0JKHikvt',$,$,$,$,$,$,$,$,$);
#16=IFCINVENTORY('3CEylLjX9L0huf3t4LJMIA',$,$,$,$,$,$,$,$,$,$);
#17=IFCRELASSIGNSTOGROUP('1X7Mz0AZrMOPkukNM5XTEV',$,$,$,(#15),$,#16);
#18=IFCELEMENTASSEMBLY('3CEylLjX9L0huf3t4LJMIA',$,$,$,$,$,$,$,$,$);
#19=IFCSPACE('3qs_CEYznSwfyPnfvmY$jn',$,$,$,$,$,$,$,$,$,$);
#20=IFCRELCONTAINEDINSPATIALSTRUCTURE('2J464n_AnPNgUfYvzrChAh',$,$,$,(#18),#19);
#21=IFCELEMENTASSEMBLY('3NmyAazpzLq8cIG7JPLlM9',$,$,$,$,$,$,$,$,$);
#22=IFCSPACE('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,$,$,$,$,$,$,$);
#23=IFCRELCONTAINEDINSPATIALSTRUCTURE('25g_sgGv1Ktw1yG4pu$Q5F',$,$,$,(#21),#22);
#24=IFCSLAB('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCBEAM('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#26=IFCRELAGGREGATES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,#24,(#25));
#27=IFCSPACE('1$n1_2RkXPbfXO7oow3KlU',$,$,$,$,$,$,$,$,$,$);
#28=IFCRELCONTAINEDINSPATIALSTRUCTURE('0aEFdeguTItxk11mFwy_RG',$,$,$,(#24),#27);
#29=IFCFURNITURE('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCDISCRETEACCESSORY('2wP8lRhDTKrxIPJKeaifuL',$,$,$,$,$,$,$,$);
#31=IFCRELNESTS('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,#29,(#30));
#32=IFCFURNITURE('0nB_kaOvDG6eluiK84kq9M',$,$,$,$,$,$,$,$);
#33=IFCDISCRETEACCESSORY('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$);
#34=IFCRELNESTS('2cohnZTsfUgQK$4UvlhCtt',$,$,$,#32,(#33));
#35=IFCFURNITURE('0SvF7iJ0nUFuDA0RAthkuL',$,$,$,$,$,$,$,$);
#36=IFCDISCRETEACCESSORY('3Qnav3G3LH0xD2qsHtUARy',$,$,$,$,$,$,$,$);
#37=IFCMECHANICALFASTENER('0twQuvOmHLbQhwOoFZW2Qc',$,$,$,$,$,$,$,$,$,$); /* Testcase */
#38=IFCRELNESTS('3yZ83FbJHHSPECOji2VuR7',$,$,$,#35,(#36));
#39=IFCRELNESTS('1zuFxqs7jRvBmbYESXTcGe',$,$,$,#36,(#37));
~~~

[Sample IDS](testcases/partof/pass-nesting_may_be_indirect.ids) - [Sample IFC: 37](testcases/partof/pass-nesting_may_be_indirect.ifc)


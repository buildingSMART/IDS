# Partof testcases

These testcases are designed to help describe behaviour in edge cases and ambiguities. All valid IDS implementations must demonstrate identical behaviour to these test cases.

## [FAIL] A non aggregated element fails an aggregate relationship

~~~xml
<partOf relation="IfcRelAggregates" minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('3q6Vcv2QX9pv9jn7w1Tkfy',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('1xzuRQJTbATh5HU$lje803',$,$,$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/fail-a_non_aggregated_element_fails_an_aggregate_relationship.ids) - [Sample IFC: 2](testcases/fail-a_non_aggregated_element_fails_an_aggregate_relationship.ifc)

## [FAIL] The aggregated whole fails an aggregate relationship

~~~xml
<partOf relation="IfcRelAggregates" minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('3q6Vcv2QX9pv9jn7w1Tkfy',$,$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCWALL('1xzuRQJTbATh5HU$lje803',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('3WbNxN2WH6jPcntlmw1Y_g',$,$,$,#1,(#2));
~~~

[Sample IDS](testcases/fail-the_aggregated_whole_fails_an_aggregate_relationship.ids) - [Sample IFC: 1](testcases/fail-the_aggregated_whole_fails_an_aggregate_relationship.ifc)

## [PASS] The aggregated part passes an aggregate relationship

~~~xml
<partOf relation="IfcRelAggregates" minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('3q6Vcv2QX9pv9jn7w1Tkfy',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('1xzuRQJTbATh5HU$lje803',$,$,$,$,$,$,$,$); /* Testcase */
#3=IFCRELAGGREGATES('3WbNxN2WH6jPcntlmw1Y_g',$,$,$,#1,(#2));
~~~

[Sample IDS](testcases/pass-the_aggregated_part_passes_an_aggregate_relationship.ids) - [Sample IFC: 2](testcases/pass-the_aggregated_part_passes_an_aggregate_relationship.ifc)

## [PASS] An aggregate may specify the entity of the whole 1/2

~~~xml
<partOf relation="IfcRelAggregates" minOccurs="1" maxOccurs="1">
  <entity>
    <simpleValue>IFCSLAB</simpleValue>
  </entity>
</partOf>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('3q6Vcv2QX9pv9jn7w1Tkfy',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('1xzuRQJTbATh5HU$lje803',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('3WbNxN2WH6jPcntlmw1Y_g',$,$,$,#1,(#2));
#4=IFCSLAB('2iKCmqMGjETeuISTotOcx6',$,$,$,$,$,$,$,$);
#5=IFCBEAM('2YGdsKUi99Eu4wAe6IZM6_',$,$,$,$,$,$,$,$); /* Testcase */
#6=IFCRELAGGREGATES('3aaOK736L0WOR3R$pdAKUx',$,$,$,#4,(#5));
~~~

[Sample IDS](testcases/pass-an_aggregate_may_specify_the_entity_of_the_whole_1_2.ids) - [Sample IFC: 5](testcases/pass-an_aggregate_may_specify_the_entity_of_the_whole_1_2.ifc)

## [FAIL] An aggregate may specify the entity of the whole 2/2

~~~xml
<partOf relation="IfcRelAggregates" minOccurs="1" maxOccurs="1">
  <entity>
    <simpleValue>IFCWALL</simpleValue>
  </entity>
</partOf>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('3q6Vcv2QX9pv9jn7w1Tkfy',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('1xzuRQJTbATh5HU$lje803',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('3WbNxN2WH6jPcntlmw1Y_g',$,$,$,#1,(#2));
#4=IFCSLAB('2iKCmqMGjETeuISTotOcx6',$,$,$,$,$,$,$,$);
#5=IFCBEAM('2YGdsKUi99Eu4wAe6IZM6_',$,$,$,$,$,$,$,$); /* Testcase */
#6=IFCRELAGGREGATES('3aaOK736L0WOR3R$pdAKUx',$,$,$,#4,(#5));
~~~

[Sample IDS](testcases/fail-an_aggregate_may_specify_the_entity_of_the_whole_2_2.ids) - [Sample IFC: 5](testcases/fail-an_aggregate_may_specify_the_entity_of_the_whole_2_2.ifc)

## [PASS] An aggregate entity may pass any ancestral whole passes

~~~xml
<partOf relation="IfcRelAggregates" minOccurs="1" maxOccurs="1">
  <entity>
    <simpleValue>IFCELEMENTASSEMBLY</simpleValue>
  </entity>
</partOf>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('3q6Vcv2QX9pv9jn7w1Tkfy',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('1xzuRQJTbATh5HU$lje803',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('3WbNxN2WH6jPcntlmw1Y_g',$,$,$,#1,(#2));
#4=IFCSLAB('2iKCmqMGjETeuISTotOcx6',$,$,$,$,$,$,$,$);
#5=IFCBEAM('2YGdsKUi99Eu4wAe6IZM6_',$,$,$,$,$,$,$,$);
#6=IFCRELAGGREGATES('3aaOK736L0WOR3R$pdAKUx',$,$,$,#4,(#5));
#7=IFCELEMENTASSEMBLY('12_vEf7ZT0auJQi6tnfI1z',$,$,$,$,$,$,$,$,$);
#8=IFCSLAB('2tXathYg5Ca8bkTCdMneXf',$,$,$,$,$,$,$,$);
#9=IFCBEAM('2p$vFGmN16ph28D3CBDkJE',$,$,$,$,$,$,$,$); /* Testcase */
#10=IFCRELAGGREGATES('0upIhFj8L1gvWaZCoNZa31',$,$,$,#7,(#8));
#11=IFCRELAGGREGATES('1Mc4apqh92CAAfd2zwVblr',$,$,$,#8,(#9));
~~~

[Sample IDS](testcases/pass-an_aggregate_entity_may_pass_any_ancestral_whole_passes.ids) - [Sample IFC: 9](testcases/pass-an_aggregate_entity_may_pass_any_ancestral_whole_passes.ifc)

## [FAIL] A non grouped element fails a group relationship

~~~xml
<partOf relation="IfcRelAssignsToGroup" minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('3q6Vcv2QX9pv9jn7w1Tkfy',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('1xzuRQJTbATh5HU$lje803',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('3WbNxN2WH6jPcntlmw1Y_g',$,$,$,#1,(#2));
#4=IFCSLAB('2iKCmqMGjETeuISTotOcx6',$,$,$,$,$,$,$,$);
#5=IFCBEAM('2YGdsKUi99Eu4wAe6IZM6_',$,$,$,$,$,$,$,$);
#6=IFCRELAGGREGATES('3aaOK736L0WOR3R$pdAKUx',$,$,$,#4,(#5));
#7=IFCELEMENTASSEMBLY('12_vEf7ZT0auJQi6tnfI1z',$,$,$,$,$,$,$,$,$);
#8=IFCSLAB('2tXathYg5Ca8bkTCdMneXf',$,$,$,$,$,$,$,$);
#9=IFCBEAM('2p$vFGmN16ph28D3CBDkJE',$,$,$,$,$,$,$,$);
#10=IFCRELAGGREGATES('0upIhFj8L1gvWaZCoNZa31',$,$,$,#7,(#8));
#11=IFCRELAGGREGATES('1Mc4apqh92CAAfd2zwVblr',$,$,$,#8,(#9));
#12=IFCELEMENTASSEMBLY('0N5j0KIfv0WATOitVZt6Bf',$,$,$,$,$,$,$,$,$); /* Testcase */
#13=IFCGROUP('0BvP02Pf17UAOxyvD0LmfW',$,'Unnamed','',$);
~~~

[Sample IDS](testcases/fail-a_non_grouped_element_fails_a_group_relationship.ids) - [Sample IFC: 12](testcases/fail-a_non_grouped_element_fails_a_group_relationship.ifc)

## [PASS] A grouped element passes a group relationship

~~~xml
<partOf relation="IfcRelAssignsToGroup" minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('3q6Vcv2QX9pv9jn7w1Tkfy',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('1xzuRQJTbATh5HU$lje803',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('3WbNxN2WH6jPcntlmw1Y_g',$,$,$,#1,(#2));
#4=IFCSLAB('2iKCmqMGjETeuISTotOcx6',$,$,$,$,$,$,$,$);
#5=IFCBEAM('2YGdsKUi99Eu4wAe6IZM6_',$,$,$,$,$,$,$,$);
#6=IFCRELAGGREGATES('3aaOK736L0WOR3R$pdAKUx',$,$,$,#4,(#5));
#7=IFCELEMENTASSEMBLY('12_vEf7ZT0auJQi6tnfI1z',$,$,$,$,$,$,$,$,$);
#8=IFCSLAB('2tXathYg5Ca8bkTCdMneXf',$,$,$,$,$,$,$,$);
#9=IFCBEAM('2p$vFGmN16ph28D3CBDkJE',$,$,$,$,$,$,$,$);
#10=IFCRELAGGREGATES('0upIhFj8L1gvWaZCoNZa31',$,$,$,#7,(#8));
#11=IFCRELAGGREGATES('1Mc4apqh92CAAfd2zwVblr',$,$,$,#8,(#9));
#12=IFCELEMENTASSEMBLY('0N5j0KIfv0WATOitVZt6Bf',$,$,$,$,$,$,$,$,$); /* Testcase */
#13=IFCGROUP('0BvP02Pf17UAOxyvD0LmfW',$,'Unnamed','',$);
#14=IFCRELASSIGNSTOGROUP('261gu6Smz1vOWRZ0S3Ba2Y',$,$,$,(#12),$,#13);
~~~

[Sample IDS](testcases/pass-a_grouped_element_passes_a_group_relationship.ids) - [Sample IFC: 12](testcases/pass-a_grouped_element_passes_a_group_relationship.ifc)

## [FAIL] A group entity must match exactly 1/2

~~~xml
<partOf relation="IfcRelAssignsToGroup" minOccurs="1" maxOccurs="1">
  <entity>
    <simpleValue>IFCGROUP</simpleValue>
  </entity>
</partOf>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('3q6Vcv2QX9pv9jn7w1Tkfy',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('1xzuRQJTbATh5HU$lje803',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('3WbNxN2WH6jPcntlmw1Y_g',$,$,$,#1,(#2));
#4=IFCSLAB('2iKCmqMGjETeuISTotOcx6',$,$,$,$,$,$,$,$);
#5=IFCBEAM('2YGdsKUi99Eu4wAe6IZM6_',$,$,$,$,$,$,$,$);
#6=IFCRELAGGREGATES('3aaOK736L0WOR3R$pdAKUx',$,$,$,#4,(#5));
#7=IFCELEMENTASSEMBLY('12_vEf7ZT0auJQi6tnfI1z',$,$,$,$,$,$,$,$,$);
#8=IFCSLAB('2tXathYg5Ca8bkTCdMneXf',$,$,$,$,$,$,$,$);
#9=IFCBEAM('2p$vFGmN16ph28D3CBDkJE',$,$,$,$,$,$,$,$);
#10=IFCRELAGGREGATES('0upIhFj8L1gvWaZCoNZa31',$,$,$,#7,(#8));
#11=IFCRELAGGREGATES('1Mc4apqh92CAAfd2zwVblr',$,$,$,#8,(#9));
#12=IFCELEMENTASSEMBLY('0N5j0KIfv0WATOitVZt6Bf',$,$,$,$,$,$,$,$,$);
#13=IFCGROUP('0BvP02Pf17UAOxyvD0LmfW',$,'Unnamed','',$);
#14=IFCRELASSIGNSTOGROUP('261gu6Smz1vOWRZ0S3Ba2Y',$,$,$,(#12),$,#13);
#15=IFCELEMENTASSEMBLY('0gUz2msXPEiv3NLfIhImkC',$,$,$,$,$,$,$,$,$); /* Testcase */
#16=IFCINVENTORY('21Ezrgpor4UgWptGTHouue',$,$,$,$,$,$,$,$,$,$);
#17=IFCRELASSIGNSTOGROUP('0B30NYivz3rPOyv5uMxb9U',$,$,$,(#15),$,#16);
~~~

[Sample IDS](testcases/fail-a_group_entity_must_match_exactly_1_2.ids) - [Sample IFC: 15](testcases/fail-a_group_entity_must_match_exactly_1_2.ifc)

## [PASS] A group entity must match exactly 2/2

~~~xml
<partOf relation="IfcRelAssignsToGroup" minOccurs="1" maxOccurs="1">
  <entity>
    <simpleValue>IFCINVENTORY</simpleValue>
  </entity>
</partOf>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('3q6Vcv2QX9pv9jn7w1Tkfy',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('1xzuRQJTbATh5HU$lje803',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('3WbNxN2WH6jPcntlmw1Y_g',$,$,$,#1,(#2));
#4=IFCSLAB('2iKCmqMGjETeuISTotOcx6',$,$,$,$,$,$,$,$);
#5=IFCBEAM('2YGdsKUi99Eu4wAe6IZM6_',$,$,$,$,$,$,$,$);
#6=IFCRELAGGREGATES('3aaOK736L0WOR3R$pdAKUx',$,$,$,#4,(#5));
#7=IFCELEMENTASSEMBLY('12_vEf7ZT0auJQi6tnfI1z',$,$,$,$,$,$,$,$,$);
#8=IFCSLAB('2tXathYg5Ca8bkTCdMneXf',$,$,$,$,$,$,$,$);
#9=IFCBEAM('2p$vFGmN16ph28D3CBDkJE',$,$,$,$,$,$,$,$);
#10=IFCRELAGGREGATES('0upIhFj8L1gvWaZCoNZa31',$,$,$,#7,(#8));
#11=IFCRELAGGREGATES('1Mc4apqh92CAAfd2zwVblr',$,$,$,#8,(#9));
#12=IFCELEMENTASSEMBLY('0N5j0KIfv0WATOitVZt6Bf',$,$,$,$,$,$,$,$,$);
#13=IFCGROUP('0BvP02Pf17UAOxyvD0LmfW',$,'Unnamed','',$);
#14=IFCRELASSIGNSTOGROUP('261gu6Smz1vOWRZ0S3Ba2Y',$,$,$,(#12),$,#13);
#15=IFCELEMENTASSEMBLY('0gUz2msXPEiv3NLfIhImkC',$,$,$,$,$,$,$,$,$); /* Testcase */
#16=IFCINVENTORY('21Ezrgpor4UgWptGTHouue',$,$,$,$,$,$,$,$,$,$);
#17=IFCRELASSIGNSTOGROUP('0B30NYivz3rPOyv5uMxb9U',$,$,$,(#15),$,#16);
~~~

[Sample IDS](testcases/pass-a_group_entity_must_match_exactly_2_2.ids) - [Sample IFC: 15](testcases/pass-a_group_entity_must_match_exactly_2_2.ifc)

## [FAIL] Any contained element passes a containment relationship 1/2

~~~xml
<partOf relation="IfcRelContainedInSpatialStructure" minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('3q6Vcv2QX9pv9jn7w1Tkfy',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('1xzuRQJTbATh5HU$lje803',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('3WbNxN2WH6jPcntlmw1Y_g',$,$,$,#1,(#2));
#4=IFCSLAB('2iKCmqMGjETeuISTotOcx6',$,$,$,$,$,$,$,$);
#5=IFCBEAM('2YGdsKUi99Eu4wAe6IZM6_',$,$,$,$,$,$,$,$);
#6=IFCRELAGGREGATES('3aaOK736L0WOR3R$pdAKUx',$,$,$,#4,(#5));
#7=IFCELEMENTASSEMBLY('12_vEf7ZT0auJQi6tnfI1z',$,$,$,$,$,$,$,$,$);
#8=IFCSLAB('2tXathYg5Ca8bkTCdMneXf',$,$,$,$,$,$,$,$);
#9=IFCBEAM('2p$vFGmN16ph28D3CBDkJE',$,$,$,$,$,$,$,$);
#10=IFCRELAGGREGATES('0upIhFj8L1gvWaZCoNZa31',$,$,$,#7,(#8));
#11=IFCRELAGGREGATES('1Mc4apqh92CAAfd2zwVblr',$,$,$,#8,(#9));
#12=IFCELEMENTASSEMBLY('0N5j0KIfv0WATOitVZt6Bf',$,$,$,$,$,$,$,$,$);
#13=IFCGROUP('0BvP02Pf17UAOxyvD0LmfW',$,'Unnamed','',$);
#14=IFCRELASSIGNSTOGROUP('261gu6Smz1vOWRZ0S3Ba2Y',$,$,$,(#12),$,#13);
#15=IFCELEMENTASSEMBLY('0gUz2msXPEiv3NLfIhImkC',$,$,$,$,$,$,$,$,$);
#16=IFCINVENTORY('21Ezrgpor4UgWptGTHouue',$,$,$,$,$,$,$,$,$,$);
#17=IFCRELASSIGNSTOGROUP('0B30NYivz3rPOyv5uMxb9U',$,$,$,(#15),$,#16);
#18=IFCELEMENTASSEMBLY('1dJMo3PRXFKOX_q4AEsvXA',$,$,$,$,$,$,$,$,$); /* Testcase */
#19=IFCSPACE('15jGVMw2D5Rx5WgmIHw1CE',$,$,$,$,$,$,$,$,$,$);
~~~

[Sample IDS](testcases/fail-any_contained_element_passes_a_containment_relationship_1_2.ids) - [Sample IFC: 18](testcases/fail-any_contained_element_passes_a_containment_relationship_1_2.ifc)

## [PASS] Any contained element passes a containment relationship 2/2

~~~xml
<partOf relation="IfcRelContainedInSpatialStructure" minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('3q6Vcv2QX9pv9jn7w1Tkfy',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('1xzuRQJTbATh5HU$lje803',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('3WbNxN2WH6jPcntlmw1Y_g',$,$,$,#1,(#2));
#4=IFCSLAB('2iKCmqMGjETeuISTotOcx6',$,$,$,$,$,$,$,$);
#5=IFCBEAM('2YGdsKUi99Eu4wAe6IZM6_',$,$,$,$,$,$,$,$);
#6=IFCRELAGGREGATES('3aaOK736L0WOR3R$pdAKUx',$,$,$,#4,(#5));
#7=IFCELEMENTASSEMBLY('12_vEf7ZT0auJQi6tnfI1z',$,$,$,$,$,$,$,$,$);
#8=IFCSLAB('2tXathYg5Ca8bkTCdMneXf',$,$,$,$,$,$,$,$);
#9=IFCBEAM('2p$vFGmN16ph28D3CBDkJE',$,$,$,$,$,$,$,$);
#10=IFCRELAGGREGATES('0upIhFj8L1gvWaZCoNZa31',$,$,$,#7,(#8));
#11=IFCRELAGGREGATES('1Mc4apqh92CAAfd2zwVblr',$,$,$,#8,(#9));
#12=IFCELEMENTASSEMBLY('0N5j0KIfv0WATOitVZt6Bf',$,$,$,$,$,$,$,$,$);
#13=IFCGROUP('0BvP02Pf17UAOxyvD0LmfW',$,'Unnamed','',$);
#14=IFCRELASSIGNSTOGROUP('261gu6Smz1vOWRZ0S3Ba2Y',$,$,$,(#12),$,#13);
#15=IFCELEMENTASSEMBLY('0gUz2msXPEiv3NLfIhImkC',$,$,$,$,$,$,$,$,$);
#16=IFCINVENTORY('21Ezrgpor4UgWptGTHouue',$,$,$,$,$,$,$,$,$,$);
#17=IFCRELASSIGNSTOGROUP('0B30NYivz3rPOyv5uMxb9U',$,$,$,(#15),$,#16);
#18=IFCELEMENTASSEMBLY('1dJMo3PRXFKOX_q4AEsvXA',$,$,$,$,$,$,$,$,$); /* Testcase */
#19=IFCSPACE('15jGVMw2D5Rx5WgmIHw1CE',$,$,$,$,$,$,$,$,$,$);
#20=IFCRELCONTAINEDINSPATIALSTRUCTURE('1JrlbVSNfAmg7bAe1B4H$e',$,$,$,(#18),#19);
~~~

[Sample IDS](testcases/pass-any_contained_element_passes_a_containment_relationship_2_2.ids) - [Sample IFC: 18](testcases/pass-any_contained_element_passes_a_containment_relationship_2_2.ifc)

## [FAIL] The container itself always fails

~~~xml
<partOf relation="IfcRelContainedInSpatialStructure" minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('3q6Vcv2QX9pv9jn7w1Tkfy',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('1xzuRQJTbATh5HU$lje803',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('3WbNxN2WH6jPcntlmw1Y_g',$,$,$,#1,(#2));
#4=IFCSLAB('2iKCmqMGjETeuISTotOcx6',$,$,$,$,$,$,$,$);
#5=IFCBEAM('2YGdsKUi99Eu4wAe6IZM6_',$,$,$,$,$,$,$,$);
#6=IFCRELAGGREGATES('3aaOK736L0WOR3R$pdAKUx',$,$,$,#4,(#5));
#7=IFCELEMENTASSEMBLY('12_vEf7ZT0auJQi6tnfI1z',$,$,$,$,$,$,$,$,$);
#8=IFCSLAB('2tXathYg5Ca8bkTCdMneXf',$,$,$,$,$,$,$,$);
#9=IFCBEAM('2p$vFGmN16ph28D3CBDkJE',$,$,$,$,$,$,$,$);
#10=IFCRELAGGREGATES('0upIhFj8L1gvWaZCoNZa31',$,$,$,#7,(#8));
#11=IFCRELAGGREGATES('1Mc4apqh92CAAfd2zwVblr',$,$,$,#8,(#9));
#12=IFCELEMENTASSEMBLY('0N5j0KIfv0WATOitVZt6Bf',$,$,$,$,$,$,$,$,$);
#13=IFCGROUP('0BvP02Pf17UAOxyvD0LmfW',$,'Unnamed','',$);
#14=IFCRELASSIGNSTOGROUP('261gu6Smz1vOWRZ0S3Ba2Y',$,$,$,(#12),$,#13);
#15=IFCELEMENTASSEMBLY('0gUz2msXPEiv3NLfIhImkC',$,$,$,$,$,$,$,$,$);
#16=IFCINVENTORY('21Ezrgpor4UgWptGTHouue',$,$,$,$,$,$,$,$,$,$);
#17=IFCRELASSIGNSTOGROUP('0B30NYivz3rPOyv5uMxb9U',$,$,$,(#15),$,#16);
#18=IFCELEMENTASSEMBLY('1dJMo3PRXFKOX_q4AEsvXA',$,$,$,$,$,$,$,$,$);
#19=IFCSPACE('15jGVMw2D5Rx5WgmIHw1CE',$,$,$,$,$,$,$,$,$,$); /* Testcase */
#20=IFCRELCONTAINEDINSPATIALSTRUCTURE('1JrlbVSNfAmg7bAe1B4H$e',$,$,$,(#18),#19);
~~~

[Sample IDS](testcases/fail-the_container_itself_always_fails.ids) - [Sample IFC: 19](testcases/fail-the_container_itself_always_fails.ifc)

## [FAIL] The container entity must match exactly 1/2

~~~xml
<partOf relation="IfcRelContainedInSpatialStructure" minOccurs="1" maxOccurs="1">
  <entity>
    <simpleValue>IFCSITE</simpleValue>
  </entity>
</partOf>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('3q6Vcv2QX9pv9jn7w1Tkfy',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('1xzuRQJTbATh5HU$lje803',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('3WbNxN2WH6jPcntlmw1Y_g',$,$,$,#1,(#2));
#4=IFCSLAB('2iKCmqMGjETeuISTotOcx6',$,$,$,$,$,$,$,$);
#5=IFCBEAM('2YGdsKUi99Eu4wAe6IZM6_',$,$,$,$,$,$,$,$);
#6=IFCRELAGGREGATES('3aaOK736L0WOR3R$pdAKUx',$,$,$,#4,(#5));
#7=IFCELEMENTASSEMBLY('12_vEf7ZT0auJQi6tnfI1z',$,$,$,$,$,$,$,$,$);
#8=IFCSLAB('2tXathYg5Ca8bkTCdMneXf',$,$,$,$,$,$,$,$);
#9=IFCBEAM('2p$vFGmN16ph28D3CBDkJE',$,$,$,$,$,$,$,$);
#10=IFCRELAGGREGATES('0upIhFj8L1gvWaZCoNZa31',$,$,$,#7,(#8));
#11=IFCRELAGGREGATES('1Mc4apqh92CAAfd2zwVblr',$,$,$,#8,(#9));
#12=IFCELEMENTASSEMBLY('0N5j0KIfv0WATOitVZt6Bf',$,$,$,$,$,$,$,$,$);
#13=IFCGROUP('0BvP02Pf17UAOxyvD0LmfW',$,'Unnamed','',$);
#14=IFCRELASSIGNSTOGROUP('261gu6Smz1vOWRZ0S3Ba2Y',$,$,$,(#12),$,#13);
#15=IFCELEMENTASSEMBLY('0gUz2msXPEiv3NLfIhImkC',$,$,$,$,$,$,$,$,$);
#16=IFCINVENTORY('21Ezrgpor4UgWptGTHouue',$,$,$,$,$,$,$,$,$,$);
#17=IFCRELASSIGNSTOGROUP('0B30NYivz3rPOyv5uMxb9U',$,$,$,(#15),$,#16);
#18=IFCELEMENTASSEMBLY('1dJMo3PRXFKOX_q4AEsvXA',$,$,$,$,$,$,$,$,$);
#19=IFCSPACE('15jGVMw2D5Rx5WgmIHw1CE',$,$,$,$,$,$,$,$,$,$);
#20=IFCRELCONTAINEDINSPATIALSTRUCTURE('1JrlbVSNfAmg7bAe1B4H$e',$,$,$,(#18),#19);
#21=IFCELEMENTASSEMBLY('25WIZPWNf4WBt24spo0PkM',$,$,$,$,$,$,$,$,$); /* Testcase */
#22=IFCSPACE('0ITiTI8ub12v8IJUucupNo',$,$,$,$,$,$,$,$,$,$);
#23=IFCRELCONTAINEDINSPATIALSTRUCTURE('23nLQQQ0T2sR_$9OOJVm7A',$,$,$,(#21),#22);
~~~

[Sample IDS](testcases/fail-the_container_entity_must_match_exactly_1_2.ids) - [Sample IFC: 21](testcases/fail-the_container_entity_must_match_exactly_1_2.ifc)

## [PASS] The container entity must match exactly 2/2

~~~xml
<partOf relation="IfcRelContainedInSpatialStructure" minOccurs="1" maxOccurs="1">
  <entity>
    <simpleValue>IFCSPACE</simpleValue>
  </entity>
</partOf>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('3q6Vcv2QX9pv9jn7w1Tkfy',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('1xzuRQJTbATh5HU$lje803',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('3WbNxN2WH6jPcntlmw1Y_g',$,$,$,#1,(#2));
#4=IFCSLAB('2iKCmqMGjETeuISTotOcx6',$,$,$,$,$,$,$,$);
#5=IFCBEAM('2YGdsKUi99Eu4wAe6IZM6_',$,$,$,$,$,$,$,$);
#6=IFCRELAGGREGATES('3aaOK736L0WOR3R$pdAKUx',$,$,$,#4,(#5));
#7=IFCELEMENTASSEMBLY('12_vEf7ZT0auJQi6tnfI1z',$,$,$,$,$,$,$,$,$);
#8=IFCSLAB('2tXathYg5Ca8bkTCdMneXf',$,$,$,$,$,$,$,$);
#9=IFCBEAM('2p$vFGmN16ph28D3CBDkJE',$,$,$,$,$,$,$,$);
#10=IFCRELAGGREGATES('0upIhFj8L1gvWaZCoNZa31',$,$,$,#7,(#8));
#11=IFCRELAGGREGATES('1Mc4apqh92CAAfd2zwVblr',$,$,$,#8,(#9));
#12=IFCELEMENTASSEMBLY('0N5j0KIfv0WATOitVZt6Bf',$,$,$,$,$,$,$,$,$);
#13=IFCGROUP('0BvP02Pf17UAOxyvD0LmfW',$,'Unnamed','',$);
#14=IFCRELASSIGNSTOGROUP('261gu6Smz1vOWRZ0S3Ba2Y',$,$,$,(#12),$,#13);
#15=IFCELEMENTASSEMBLY('0gUz2msXPEiv3NLfIhImkC',$,$,$,$,$,$,$,$,$);
#16=IFCINVENTORY('21Ezrgpor4UgWptGTHouue',$,$,$,$,$,$,$,$,$,$);
#17=IFCRELASSIGNSTOGROUP('0B30NYivz3rPOyv5uMxb9U',$,$,$,(#15),$,#16);
#18=IFCELEMENTASSEMBLY('1dJMo3PRXFKOX_q4AEsvXA',$,$,$,$,$,$,$,$,$);
#19=IFCSPACE('15jGVMw2D5Rx5WgmIHw1CE',$,$,$,$,$,$,$,$,$,$);
#20=IFCRELCONTAINEDINSPATIALSTRUCTURE('1JrlbVSNfAmg7bAe1B4H$e',$,$,$,(#18),#19);
#21=IFCELEMENTASSEMBLY('25WIZPWNf4WBt24spo0PkM',$,$,$,$,$,$,$,$,$); /* Testcase */
#22=IFCSPACE('0ITiTI8ub12v8IJUucupNo',$,$,$,$,$,$,$,$,$,$);
#23=IFCRELCONTAINEDINSPATIALSTRUCTURE('23nLQQQ0T2sR_$9OOJVm7A',$,$,$,(#21),#22);
~~~

[Sample IDS](testcases/pass-the_container_entity_must_match_exactly_2_2.ids) - [Sample IFC: 21](testcases/pass-the_container_entity_must_match_exactly_2_2.ifc)

## [PASS] The container may be indirect

~~~xml
<partOf relation="IfcRelContainedInSpatialStructure" minOccurs="1" maxOccurs="1">
  <entity>
    <simpleValue>IFCSPACE</simpleValue>
  </entity>
</partOf>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('3q6Vcv2QX9pv9jn7w1Tkfy',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('1xzuRQJTbATh5HU$lje803',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('3WbNxN2WH6jPcntlmw1Y_g',$,$,$,#1,(#2));
#4=IFCSLAB('2iKCmqMGjETeuISTotOcx6',$,$,$,$,$,$,$,$);
#5=IFCBEAM('2YGdsKUi99Eu4wAe6IZM6_',$,$,$,$,$,$,$,$);
#6=IFCRELAGGREGATES('3aaOK736L0WOR3R$pdAKUx',$,$,$,#4,(#5));
#7=IFCELEMENTASSEMBLY('12_vEf7ZT0auJQi6tnfI1z',$,$,$,$,$,$,$,$,$);
#8=IFCSLAB('2tXathYg5Ca8bkTCdMneXf',$,$,$,$,$,$,$,$);
#9=IFCBEAM('2p$vFGmN16ph28D3CBDkJE',$,$,$,$,$,$,$,$);
#10=IFCRELAGGREGATES('0upIhFj8L1gvWaZCoNZa31',$,$,$,#7,(#8));
#11=IFCRELAGGREGATES('1Mc4apqh92CAAfd2zwVblr',$,$,$,#8,(#9));
#12=IFCELEMENTASSEMBLY('0N5j0KIfv0WATOitVZt6Bf',$,$,$,$,$,$,$,$,$);
#13=IFCGROUP('0BvP02Pf17UAOxyvD0LmfW',$,'Unnamed','',$);
#14=IFCRELASSIGNSTOGROUP('261gu6Smz1vOWRZ0S3Ba2Y',$,$,$,(#12),$,#13);
#15=IFCELEMENTASSEMBLY('0gUz2msXPEiv3NLfIhImkC',$,$,$,$,$,$,$,$,$);
#16=IFCINVENTORY('21Ezrgpor4UgWptGTHouue',$,$,$,$,$,$,$,$,$,$);
#17=IFCRELASSIGNSTOGROUP('0B30NYivz3rPOyv5uMxb9U',$,$,$,(#15),$,#16);
#18=IFCELEMENTASSEMBLY('1dJMo3PRXFKOX_q4AEsvXA',$,$,$,$,$,$,$,$,$);
#19=IFCSPACE('15jGVMw2D5Rx5WgmIHw1CE',$,$,$,$,$,$,$,$,$,$);
#20=IFCRELCONTAINEDINSPATIALSTRUCTURE('1JrlbVSNfAmg7bAe1B4H$e',$,$,$,(#18),#19);
#21=IFCELEMENTASSEMBLY('25WIZPWNf4WBt24spo0PkM',$,$,$,$,$,$,$,$,$);
#22=IFCSPACE('0ITiTI8ub12v8IJUucupNo',$,$,$,$,$,$,$,$,$,$);
#23=IFCRELCONTAINEDINSPATIALSTRUCTURE('23nLQQQ0T2sR_$9OOJVm7A',$,$,$,(#21),#22);
#24=IFCSLAB('0_5t08fajCCQczmmyB2aCj',$,$,$,$,$,$,$,$);
#25=IFCBEAM('3yiC_yWOP3qeHgY5ujrm7F',$,$,$,$,$,$,$,$); /* Testcase */
#26=IFCRELAGGREGATES('3P8JEaJOHCyvombwP650HS',$,$,$,#24,(#25));
#27=IFCSPACE('1Ld8Y34895tgbpIfHIwdoP',$,$,$,$,$,$,$,$,$,$);
#28=IFCRELCONTAINEDINSPATIALSTRUCTURE('1gYkvL73fE6xFLCFVynsqy',$,$,$,(#24),#27);
~~~

[Sample IDS](testcases/pass-the_container_may_be_indirect.ids) - [Sample IFC: 25](testcases/pass-the_container_may_be_indirect.ifc)

## [PASS] Any nested part passes a nest relationship

~~~xml
<partOf relation="IfcRelNests" minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('3q6Vcv2QX9pv9jn7w1Tkfy',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('1xzuRQJTbATh5HU$lje803',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('3WbNxN2WH6jPcntlmw1Y_g',$,$,$,#1,(#2));
#4=IFCSLAB('2iKCmqMGjETeuISTotOcx6',$,$,$,$,$,$,$,$);
#5=IFCBEAM('2YGdsKUi99Eu4wAe6IZM6_',$,$,$,$,$,$,$,$);
#6=IFCRELAGGREGATES('3aaOK736L0WOR3R$pdAKUx',$,$,$,#4,(#5));
#7=IFCELEMENTASSEMBLY('12_vEf7ZT0auJQi6tnfI1z',$,$,$,$,$,$,$,$,$);
#8=IFCSLAB('2tXathYg5Ca8bkTCdMneXf',$,$,$,$,$,$,$,$);
#9=IFCBEAM('2p$vFGmN16ph28D3CBDkJE',$,$,$,$,$,$,$,$);
#10=IFCRELAGGREGATES('0upIhFj8L1gvWaZCoNZa31',$,$,$,#7,(#8));
#11=IFCRELAGGREGATES('1Mc4apqh92CAAfd2zwVblr',$,$,$,#8,(#9));
#12=IFCELEMENTASSEMBLY('0N5j0KIfv0WATOitVZt6Bf',$,$,$,$,$,$,$,$,$);
#13=IFCGROUP('0BvP02Pf17UAOxyvD0LmfW',$,'Unnamed','',$);
#14=IFCRELASSIGNSTOGROUP('261gu6Smz1vOWRZ0S3Ba2Y',$,$,$,(#12),$,#13);
#15=IFCELEMENTASSEMBLY('0gUz2msXPEiv3NLfIhImkC',$,$,$,$,$,$,$,$,$);
#16=IFCINVENTORY('21Ezrgpor4UgWptGTHouue',$,$,$,$,$,$,$,$,$,$);
#17=IFCRELASSIGNSTOGROUP('0B30NYivz3rPOyv5uMxb9U',$,$,$,(#15),$,#16);
#18=IFCELEMENTASSEMBLY('1dJMo3PRXFKOX_q4AEsvXA',$,$,$,$,$,$,$,$,$);
#19=IFCSPACE('15jGVMw2D5Rx5WgmIHw1CE',$,$,$,$,$,$,$,$,$,$);
#20=IFCRELCONTAINEDINSPATIALSTRUCTURE('1JrlbVSNfAmg7bAe1B4H$e',$,$,$,(#18),#19);
#21=IFCELEMENTASSEMBLY('25WIZPWNf4WBt24spo0PkM',$,$,$,$,$,$,$,$,$);
#22=IFCSPACE('0ITiTI8ub12v8IJUucupNo',$,$,$,$,$,$,$,$,$,$);
#23=IFCRELCONTAINEDINSPATIALSTRUCTURE('23nLQQQ0T2sR_$9OOJVm7A',$,$,$,(#21),#22);
#24=IFCSLAB('0_5t08fajCCQczmmyB2aCj',$,$,$,$,$,$,$,$);
#25=IFCBEAM('3yiC_yWOP3qeHgY5ujrm7F',$,$,$,$,$,$,$,$);
#26=IFCRELAGGREGATES('3P8JEaJOHCyvombwP650HS',$,$,$,#24,(#25));
#27=IFCSPACE('1Ld8Y34895tgbpIfHIwdoP',$,$,$,$,$,$,$,$,$,$);
#28=IFCRELCONTAINEDINSPATIALSTRUCTURE('1gYkvL73fE6xFLCFVynsqy',$,$,$,(#24),#27);
#29=IFCFURNITURE('2$pez7nKHD2f7zeA15Z2ol',$,$,$,$,$,$,$,$);
#30=IFCDISCRETEACCESSORY('2Ux4P2qkv0yvjSloAOOjlf',$,$,$,$,$,$,$,$); /* Testcase */
#31=IFCRELNESTS('2dxZvZ5YX3TAavu_cvIkmQ',$,$,$,#29,(#30));
~~~

[Sample IDS](testcases/pass-any_nested_part_passes_a_nest_relationship.ids) - [Sample IFC: 30](testcases/pass-any_nested_part_passes_a_nest_relationship.ifc)

## [FAIL] Any nested whole fails a nest relationship

~~~xml
<partOf relation="IfcRelNests" minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('3q6Vcv2QX9pv9jn7w1Tkfy',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('1xzuRQJTbATh5HU$lje803',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('3WbNxN2WH6jPcntlmw1Y_g',$,$,$,#1,(#2));
#4=IFCSLAB('2iKCmqMGjETeuISTotOcx6',$,$,$,$,$,$,$,$);
#5=IFCBEAM('2YGdsKUi99Eu4wAe6IZM6_',$,$,$,$,$,$,$,$);
#6=IFCRELAGGREGATES('3aaOK736L0WOR3R$pdAKUx',$,$,$,#4,(#5));
#7=IFCELEMENTASSEMBLY('12_vEf7ZT0auJQi6tnfI1z',$,$,$,$,$,$,$,$,$);
#8=IFCSLAB('2tXathYg5Ca8bkTCdMneXf',$,$,$,$,$,$,$,$);
#9=IFCBEAM('2p$vFGmN16ph28D3CBDkJE',$,$,$,$,$,$,$,$);
#10=IFCRELAGGREGATES('0upIhFj8L1gvWaZCoNZa31',$,$,$,#7,(#8));
#11=IFCRELAGGREGATES('1Mc4apqh92CAAfd2zwVblr',$,$,$,#8,(#9));
#12=IFCELEMENTASSEMBLY('0N5j0KIfv0WATOitVZt6Bf',$,$,$,$,$,$,$,$,$);
#13=IFCGROUP('0BvP02Pf17UAOxyvD0LmfW',$,'Unnamed','',$);
#14=IFCRELASSIGNSTOGROUP('261gu6Smz1vOWRZ0S3Ba2Y',$,$,$,(#12),$,#13);
#15=IFCELEMENTASSEMBLY('0gUz2msXPEiv3NLfIhImkC',$,$,$,$,$,$,$,$,$);
#16=IFCINVENTORY('21Ezrgpor4UgWptGTHouue',$,$,$,$,$,$,$,$,$,$);
#17=IFCRELASSIGNSTOGROUP('0B30NYivz3rPOyv5uMxb9U',$,$,$,(#15),$,#16);
#18=IFCELEMENTASSEMBLY('1dJMo3PRXFKOX_q4AEsvXA',$,$,$,$,$,$,$,$,$);
#19=IFCSPACE('15jGVMw2D5Rx5WgmIHw1CE',$,$,$,$,$,$,$,$,$,$);
#20=IFCRELCONTAINEDINSPATIALSTRUCTURE('1JrlbVSNfAmg7bAe1B4H$e',$,$,$,(#18),#19);
#21=IFCELEMENTASSEMBLY('25WIZPWNf4WBt24spo0PkM',$,$,$,$,$,$,$,$,$);
#22=IFCSPACE('0ITiTI8ub12v8IJUucupNo',$,$,$,$,$,$,$,$,$,$);
#23=IFCRELCONTAINEDINSPATIALSTRUCTURE('23nLQQQ0T2sR_$9OOJVm7A',$,$,$,(#21),#22);
#24=IFCSLAB('0_5t08fajCCQczmmyB2aCj',$,$,$,$,$,$,$,$);
#25=IFCBEAM('3yiC_yWOP3qeHgY5ujrm7F',$,$,$,$,$,$,$,$);
#26=IFCRELAGGREGATES('3P8JEaJOHCyvombwP650HS',$,$,$,#24,(#25));
#27=IFCSPACE('1Ld8Y34895tgbpIfHIwdoP',$,$,$,$,$,$,$,$,$,$);
#28=IFCRELCONTAINEDINSPATIALSTRUCTURE('1gYkvL73fE6xFLCFVynsqy',$,$,$,(#24),#27);
#29=IFCFURNITURE('2$pez7nKHD2f7zeA15Z2ol',$,$,$,$,$,$,$,$); /* Testcase */
#30=IFCDISCRETEACCESSORY('2Ux4P2qkv0yvjSloAOOjlf',$,$,$,$,$,$,$,$);
#31=IFCRELNESTS('2dxZvZ5YX3TAavu_cvIkmQ',$,$,$,#29,(#30));
~~~

[Sample IDS](testcases/fail-any_nested_whole_fails_a_nest_relationship.ids) - [Sample IFC: 29](testcases/fail-any_nested_whole_fails_a_nest_relationship.ifc)

## [FAIL] The nest entity must match exactly 1/2

~~~xml
<partOf relation="IfcRelNests" minOccurs="1" maxOccurs="1">
  <entity>
    <simpleValue>IFCBEAM</simpleValue>
  </entity>
</partOf>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('3q6Vcv2QX9pv9jn7w1Tkfy',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('1xzuRQJTbATh5HU$lje803',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('3WbNxN2WH6jPcntlmw1Y_g',$,$,$,#1,(#2));
#4=IFCSLAB('2iKCmqMGjETeuISTotOcx6',$,$,$,$,$,$,$,$);
#5=IFCBEAM('2YGdsKUi99Eu4wAe6IZM6_',$,$,$,$,$,$,$,$);
#6=IFCRELAGGREGATES('3aaOK736L0WOR3R$pdAKUx',$,$,$,#4,(#5));
#7=IFCELEMENTASSEMBLY('12_vEf7ZT0auJQi6tnfI1z',$,$,$,$,$,$,$,$,$);
#8=IFCSLAB('2tXathYg5Ca8bkTCdMneXf',$,$,$,$,$,$,$,$);
#9=IFCBEAM('2p$vFGmN16ph28D3CBDkJE',$,$,$,$,$,$,$,$);
#10=IFCRELAGGREGATES('0upIhFj8L1gvWaZCoNZa31',$,$,$,#7,(#8));
#11=IFCRELAGGREGATES('1Mc4apqh92CAAfd2zwVblr',$,$,$,#8,(#9));
#12=IFCELEMENTASSEMBLY('0N5j0KIfv0WATOitVZt6Bf',$,$,$,$,$,$,$,$,$);
#13=IFCGROUP('0BvP02Pf17UAOxyvD0LmfW',$,'Unnamed','',$);
#14=IFCRELASSIGNSTOGROUP('261gu6Smz1vOWRZ0S3Ba2Y',$,$,$,(#12),$,#13);
#15=IFCELEMENTASSEMBLY('0gUz2msXPEiv3NLfIhImkC',$,$,$,$,$,$,$,$,$);
#16=IFCINVENTORY('21Ezrgpor4UgWptGTHouue',$,$,$,$,$,$,$,$,$,$);
#17=IFCRELASSIGNSTOGROUP('0B30NYivz3rPOyv5uMxb9U',$,$,$,(#15),$,#16);
#18=IFCELEMENTASSEMBLY('1dJMo3PRXFKOX_q4AEsvXA',$,$,$,$,$,$,$,$,$);
#19=IFCSPACE('15jGVMw2D5Rx5WgmIHw1CE',$,$,$,$,$,$,$,$,$,$);
#20=IFCRELCONTAINEDINSPATIALSTRUCTURE('1JrlbVSNfAmg7bAe1B4H$e',$,$,$,(#18),#19);
#21=IFCELEMENTASSEMBLY('25WIZPWNf4WBt24spo0PkM',$,$,$,$,$,$,$,$,$);
#22=IFCSPACE('0ITiTI8ub12v8IJUucupNo',$,$,$,$,$,$,$,$,$,$);
#23=IFCRELCONTAINEDINSPATIALSTRUCTURE('23nLQQQ0T2sR_$9OOJVm7A',$,$,$,(#21),#22);
#24=IFCSLAB('0_5t08fajCCQczmmyB2aCj',$,$,$,$,$,$,$,$);
#25=IFCBEAM('3yiC_yWOP3qeHgY5ujrm7F',$,$,$,$,$,$,$,$);
#26=IFCRELAGGREGATES('3P8JEaJOHCyvombwP650HS',$,$,$,#24,(#25));
#27=IFCSPACE('1Ld8Y34895tgbpIfHIwdoP',$,$,$,$,$,$,$,$,$,$);
#28=IFCRELCONTAINEDINSPATIALSTRUCTURE('1gYkvL73fE6xFLCFVynsqy',$,$,$,(#24),#27);
#29=IFCFURNITURE('2$pez7nKHD2f7zeA15Z2ol',$,$,$,$,$,$,$,$);
#30=IFCDISCRETEACCESSORY('2Ux4P2qkv0yvjSloAOOjlf',$,$,$,$,$,$,$,$);
#31=IFCRELNESTS('2dxZvZ5YX3TAavu_cvIkmQ',$,$,$,#29,(#30));
#32=IFCFURNITURE('15G$s4EIjEPuly7GP10UVL',$,$,$,$,$,$,$,$);
#33=IFCDISCRETEACCESSORY('2G_v87JE53JRMTfzL5EVKF',$,$,$,$,$,$,$,$); /* Testcase */
#34=IFCRELNESTS('3CAXK8djj0xhGX8CGijScX',$,$,$,#32,(#33));
~~~

[Sample IDS](testcases/fail-the_nest_entity_must_match_exactly_1_2.ids) - [Sample IFC: 33](testcases/fail-the_nest_entity_must_match_exactly_1_2.ifc)

## [PASS] The nest entity must match exactly 2/2

~~~xml
<partOf relation="IfcRelNests" minOccurs="1" maxOccurs="1">
  <entity>
    <simpleValue>IFCFURNITURE</simpleValue>
  </entity>
</partOf>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('3q6Vcv2QX9pv9jn7w1Tkfy',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('1xzuRQJTbATh5HU$lje803',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('3WbNxN2WH6jPcntlmw1Y_g',$,$,$,#1,(#2));
#4=IFCSLAB('2iKCmqMGjETeuISTotOcx6',$,$,$,$,$,$,$,$);
#5=IFCBEAM('2YGdsKUi99Eu4wAe6IZM6_',$,$,$,$,$,$,$,$);
#6=IFCRELAGGREGATES('3aaOK736L0WOR3R$pdAKUx',$,$,$,#4,(#5));
#7=IFCELEMENTASSEMBLY('12_vEf7ZT0auJQi6tnfI1z',$,$,$,$,$,$,$,$,$);
#8=IFCSLAB('2tXathYg5Ca8bkTCdMneXf',$,$,$,$,$,$,$,$);
#9=IFCBEAM('2p$vFGmN16ph28D3CBDkJE',$,$,$,$,$,$,$,$);
#10=IFCRELAGGREGATES('0upIhFj8L1gvWaZCoNZa31',$,$,$,#7,(#8));
#11=IFCRELAGGREGATES('1Mc4apqh92CAAfd2zwVblr',$,$,$,#8,(#9));
#12=IFCELEMENTASSEMBLY('0N5j0KIfv0WATOitVZt6Bf',$,$,$,$,$,$,$,$,$);
#13=IFCGROUP('0BvP02Pf17UAOxyvD0LmfW',$,'Unnamed','',$);
#14=IFCRELASSIGNSTOGROUP('261gu6Smz1vOWRZ0S3Ba2Y',$,$,$,(#12),$,#13);
#15=IFCELEMENTASSEMBLY('0gUz2msXPEiv3NLfIhImkC',$,$,$,$,$,$,$,$,$);
#16=IFCINVENTORY('21Ezrgpor4UgWptGTHouue',$,$,$,$,$,$,$,$,$,$);
#17=IFCRELASSIGNSTOGROUP('0B30NYivz3rPOyv5uMxb9U',$,$,$,(#15),$,#16);
#18=IFCELEMENTASSEMBLY('1dJMo3PRXFKOX_q4AEsvXA',$,$,$,$,$,$,$,$,$);
#19=IFCSPACE('15jGVMw2D5Rx5WgmIHw1CE',$,$,$,$,$,$,$,$,$,$);
#20=IFCRELCONTAINEDINSPATIALSTRUCTURE('1JrlbVSNfAmg7bAe1B4H$e',$,$,$,(#18),#19);
#21=IFCELEMENTASSEMBLY('25WIZPWNf4WBt24spo0PkM',$,$,$,$,$,$,$,$,$);
#22=IFCSPACE('0ITiTI8ub12v8IJUucupNo',$,$,$,$,$,$,$,$,$,$);
#23=IFCRELCONTAINEDINSPATIALSTRUCTURE('23nLQQQ0T2sR_$9OOJVm7A',$,$,$,(#21),#22);
#24=IFCSLAB('0_5t08fajCCQczmmyB2aCj',$,$,$,$,$,$,$,$);
#25=IFCBEAM('3yiC_yWOP3qeHgY5ujrm7F',$,$,$,$,$,$,$,$);
#26=IFCRELAGGREGATES('3P8JEaJOHCyvombwP650HS',$,$,$,#24,(#25));
#27=IFCSPACE('1Ld8Y34895tgbpIfHIwdoP',$,$,$,$,$,$,$,$,$,$);
#28=IFCRELCONTAINEDINSPATIALSTRUCTURE('1gYkvL73fE6xFLCFVynsqy',$,$,$,(#24),#27);
#29=IFCFURNITURE('2$pez7nKHD2f7zeA15Z2ol',$,$,$,$,$,$,$,$);
#30=IFCDISCRETEACCESSORY('2Ux4P2qkv0yvjSloAOOjlf',$,$,$,$,$,$,$,$);
#31=IFCRELNESTS('2dxZvZ5YX3TAavu_cvIkmQ',$,$,$,#29,(#30));
#32=IFCFURNITURE('15G$s4EIjEPuly7GP10UVL',$,$,$,$,$,$,$,$);
#33=IFCDISCRETEACCESSORY('2G_v87JE53JRMTfzL5EVKF',$,$,$,$,$,$,$,$); /* Testcase */
#34=IFCRELNESTS('3CAXK8djj0xhGX8CGijScX',$,$,$,#32,(#33));
~~~

[Sample IDS](testcases/pass-the_nest_entity_must_match_exactly_2_2.ids) - [Sample IFC: 33](testcases/pass-the_nest_entity_must_match_exactly_2_2.ifc)

## [PASS] Nesting may be indirect

~~~xml
<partOf relation="IfcRelNests" minOccurs="1" maxOccurs="1">
  <entity>
    <simpleValue>IFCFURNITURE</simpleValue>
  </entity>
</partOf>
~~~

~~~lua
#1=IFCELEMENTASSEMBLY('3q6Vcv2QX9pv9jn7w1Tkfy',$,$,$,$,$,$,$,$,$);
#2=IFCWALL('1xzuRQJTbATh5HU$lje803',$,$,$,$,$,$,$,$);
#3=IFCRELAGGREGATES('3WbNxN2WH6jPcntlmw1Y_g',$,$,$,#1,(#2));
#4=IFCSLAB('2iKCmqMGjETeuISTotOcx6',$,$,$,$,$,$,$,$);
#5=IFCBEAM('2YGdsKUi99Eu4wAe6IZM6_',$,$,$,$,$,$,$,$);
#6=IFCRELAGGREGATES('3aaOK736L0WOR3R$pdAKUx',$,$,$,#4,(#5));
#7=IFCELEMENTASSEMBLY('12_vEf7ZT0auJQi6tnfI1z',$,$,$,$,$,$,$,$,$);
#8=IFCSLAB('2tXathYg5Ca8bkTCdMneXf',$,$,$,$,$,$,$,$);
#9=IFCBEAM('2p$vFGmN16ph28D3CBDkJE',$,$,$,$,$,$,$,$);
#10=IFCRELAGGREGATES('0upIhFj8L1gvWaZCoNZa31',$,$,$,#7,(#8));
#11=IFCRELAGGREGATES('1Mc4apqh92CAAfd2zwVblr',$,$,$,#8,(#9));
#12=IFCELEMENTASSEMBLY('0N5j0KIfv0WATOitVZt6Bf',$,$,$,$,$,$,$,$,$);
#13=IFCGROUP('0BvP02Pf17UAOxyvD0LmfW',$,'Unnamed','',$);
#14=IFCRELASSIGNSTOGROUP('261gu6Smz1vOWRZ0S3Ba2Y',$,$,$,(#12),$,#13);
#15=IFCELEMENTASSEMBLY('0gUz2msXPEiv3NLfIhImkC',$,$,$,$,$,$,$,$,$);
#16=IFCINVENTORY('21Ezrgpor4UgWptGTHouue',$,$,$,$,$,$,$,$,$,$);
#17=IFCRELASSIGNSTOGROUP('0B30NYivz3rPOyv5uMxb9U',$,$,$,(#15),$,#16);
#18=IFCELEMENTASSEMBLY('1dJMo3PRXFKOX_q4AEsvXA',$,$,$,$,$,$,$,$,$);
#19=IFCSPACE('15jGVMw2D5Rx5WgmIHw1CE',$,$,$,$,$,$,$,$,$,$);
#20=IFCRELCONTAINEDINSPATIALSTRUCTURE('1JrlbVSNfAmg7bAe1B4H$e',$,$,$,(#18),#19);
#21=IFCELEMENTASSEMBLY('25WIZPWNf4WBt24spo0PkM',$,$,$,$,$,$,$,$,$);
#22=IFCSPACE('0ITiTI8ub12v8IJUucupNo',$,$,$,$,$,$,$,$,$,$);
#23=IFCRELCONTAINEDINSPATIALSTRUCTURE('23nLQQQ0T2sR_$9OOJVm7A',$,$,$,(#21),#22);
#24=IFCSLAB('0_5t08fajCCQczmmyB2aCj',$,$,$,$,$,$,$,$);
#25=IFCBEAM('3yiC_yWOP3qeHgY5ujrm7F',$,$,$,$,$,$,$,$);
#26=IFCRELAGGREGATES('3P8JEaJOHCyvombwP650HS',$,$,$,#24,(#25));
#27=IFCSPACE('1Ld8Y34895tgbpIfHIwdoP',$,$,$,$,$,$,$,$,$,$);
#28=IFCRELCONTAINEDINSPATIALSTRUCTURE('1gYkvL73fE6xFLCFVynsqy',$,$,$,(#24),#27);
#29=IFCFURNITURE('2$pez7nKHD2f7zeA15Z2ol',$,$,$,$,$,$,$,$);
#30=IFCDISCRETEACCESSORY('2Ux4P2qkv0yvjSloAOOjlf',$,$,$,$,$,$,$,$);
#31=IFCRELNESTS('2dxZvZ5YX3TAavu_cvIkmQ',$,$,$,#29,(#30));
#32=IFCFURNITURE('15G$s4EIjEPuly7GP10UVL',$,$,$,$,$,$,$,$);
#33=IFCDISCRETEACCESSORY('2G_v87JE53JRMTfzL5EVKF',$,$,$,$,$,$,$,$);
#34=IFCRELNESTS('3CAXK8djj0xhGX8CGijScX',$,$,$,#32,(#33));
#35=IFCFURNITURE('14gmTF4IrDwwnOhRjb4DfH',$,$,$,$,$,$,$,$);
#36=IFCDISCRETEACCESSORY('3uvI$dxED7W82lNArVoYBz',$,$,$,$,$,$,$,$);
#37=IFCMECHANICALFASTENER('1ISDnlnd951fTUaPLgo6QT',$,$,$,$,$,$,$,$,$,$); /* Testcase */
#38=IFCRELNESTS('2fCS1g9rzF3O_xjbSkHidH',$,$,$,#35,(#36));
#39=IFCRELNESTS('1VuQp1srD6IROUtvSU4Azv',$,$,$,#36,(#37));
~~~

[Sample IDS](testcases/pass-nesting_may_be_indirect.ids) - [Sample IFC: 37](testcases/pass-nesting_may_be_indirect.ifc)


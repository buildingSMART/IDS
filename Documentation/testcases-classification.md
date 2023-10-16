# Classification testcases

These testcases are designed to help describe behaviour in edge cases and ambiguities. All valid IDS implementations must demonstrate identical behaviour to these test cases.

## [FAIL] A classification facet with no data matches any classification 1/2

~~~xml
<classification maxOccurs="unbounded" minOccurs="1"/>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCWALL('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$); /* Testcase */
#5=IFCSLAB('0BbkGoC6vPvRW13UT7D8zH',$,$,$,$,$,$,$,$);
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,(#5),#6);
#8=IFCCOLUMN('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('0WTUhjMwvT39YBFH2pryoM',$,$,$,(#8),#9);
#11=IFCBEAM('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('2jG7cjHsrIUfgKVktNgbzi',$,$,$,(#11),#12);
#16=IFCMATERIAL('Material',$,$);
#17=IFCEXTERNALREFERENCERELATIONSHIP($,$,#6,(#16));
~~~

[Sample IDS](testcases/classification/fail-a_classification_facet_with_no_data_matches_any_classification_1_2.ids) - [Sample IFC: 4](testcases/classification/fail-a_classification_facet_with_no_data_matches_any_classification_1_2.ifc)

## [PASS] A classification facet with no data matches any classification 2/2

~~~xml
<classification maxOccurs="unbounded" minOccurs="1"/>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCWALL('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#5=IFCSLAB('0BbkGoC6vPvRW13UT7D8zH',$,$,$,$,$,$,$,$); /* Testcase */
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,(#5),#6);
#8=IFCCOLUMN('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('0WTUhjMwvT39YBFH2pryoM',$,$,$,(#8),#9);
#11=IFCBEAM('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('2jG7cjHsrIUfgKVktNgbzi',$,$,$,(#11),#12);
#16=IFCMATERIAL('Material',$,$);
#17=IFCEXTERNALREFERENCERELATIONSHIP($,$,#6,(#16));
~~~

[Sample IDS](testcases/classification/pass-a_classification_facet_with_no_data_matches_any_classification_2_2.ids) - [Sample IFC: 5](testcases/classification/pass-a_classification_facet_with_no_data_matches_any_classification_2_2.ifc)

## [PASS] A required facet checks all parameters as normal

~~~xml
<classification maxOccurs="unbounded" minOccurs="1"/>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCWALL('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#5=IFCSLAB('0BbkGoC6vPvRW13UT7D8zH',$,$,$,$,$,$,$,$); /* Testcase */
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,(#5),#6);
#8=IFCCOLUMN('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('0WTUhjMwvT39YBFH2pryoM',$,$,$,(#8),#9);
#11=IFCBEAM('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('2jG7cjHsrIUfgKVktNgbzi',$,$,$,(#11),#12);
#16=IFCMATERIAL('Material',$,$);
#17=IFCEXTERNALREFERENCERELATIONSHIP($,$,#6,(#16));
~~~

[Sample IDS](testcases/classification/pass-a_required_facet_checks_all_parameters_as_normal.ids) - [Sample IFC: 5](testcases/classification/pass-a_required_facet_checks_all_parameters_as_normal.ifc)

## [FAIL] A prohibited facet returns the opposite of a required facet

~~~xml
<classification minOccurs="0" maxOccurs="0"/>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCWALL('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#5=IFCSLAB('0BbkGoC6vPvRW13UT7D8zH',$,$,$,$,$,$,$,$); /* Testcase */
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,(#5),#6);
#8=IFCCOLUMN('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('0WTUhjMwvT39YBFH2pryoM',$,$,$,(#8),#9);
#11=IFCBEAM('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('2jG7cjHsrIUfgKVktNgbzi',$,$,$,(#11),#12);
#16=IFCMATERIAL('Material',$,$);
#17=IFCEXTERNALREFERENCERELATIONSHIP($,$,#6,(#16));
~~~

[Sample IDS](testcases/classification/fail-a_prohibited_facet_returns_the_opposite_of_a_required_facet.ids) - [Sample IFC: 5](testcases/classification/fail-a_prohibited_facet_returns_the_opposite_of_a_required_facet.ifc)

## [PASS] An optional facet always passes regardless of outcome 1/2

~~~xml
<classification minOccurs="0" maxOccurs="unbounded"/>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCWALL('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$); /* Testcase */
#5=IFCSLAB('0BbkGoC6vPvRW13UT7D8zH',$,$,$,$,$,$,$,$);
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,(#5),#6);
#8=IFCCOLUMN('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('0WTUhjMwvT39YBFH2pryoM',$,$,$,(#8),#9);
#11=IFCBEAM('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('2jG7cjHsrIUfgKVktNgbzi',$,$,$,(#11),#12);
#16=IFCMATERIAL('Material',$,$);
#17=IFCEXTERNALREFERENCERELATIONSHIP($,$,#6,(#16));
~~~

[Sample IDS](testcases/classification/pass-an_optional_facet_always_passes_regardless_of_outcome_1_2.ids) - [Sample IFC: 4](testcases/classification/pass-an_optional_facet_always_passes_regardless_of_outcome_1_2.ifc)

## [PASS] An optional facet always passes regardless of outcome 2/2

~~~xml
<classification minOccurs="0" maxOccurs="unbounded"/>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCWALL('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#5=IFCSLAB('0BbkGoC6vPvRW13UT7D8zH',$,$,$,$,$,$,$,$); /* Testcase */
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,(#5),#6);
#8=IFCCOLUMN('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('0WTUhjMwvT39YBFH2pryoM',$,$,$,(#8),#9);
#11=IFCBEAM('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('2jG7cjHsrIUfgKVktNgbzi',$,$,$,(#11),#12);
#16=IFCMATERIAL('Material',$,$);
#17=IFCEXTERNALREFERENCERELATIONSHIP($,$,#6,(#16));
~~~

[Sample IDS](testcases/classification/pass-an_optional_facet_always_passes_regardless_of_outcome_2_2.ids) - [Sample IFC: 5](testcases/classification/pass-an_optional_facet_always_passes_regardless_of_outcome_2_2.ifc)

## [PASS] Values should match exactly if lightweight classifications are used

~~~xml
<classification maxOccurs="unbounded" minOccurs="1">
  <value>
    <simpleValue>1</simpleValue>
  </value>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCWALL('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#5=IFCSLAB('0BbkGoC6vPvRW13UT7D8zH',$,$,$,$,$,$,$,$); /* Testcase */
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,(#5),#6);
#8=IFCCOLUMN('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('0WTUhjMwvT39YBFH2pryoM',$,$,$,(#8),#9);
#11=IFCBEAM('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('2jG7cjHsrIUfgKVktNgbzi',$,$,$,(#11),#12);
#16=IFCMATERIAL('Material',$,$);
#17=IFCEXTERNALREFERENCERELATIONSHIP($,$,#6,(#16));
~~~

[Sample IDS](testcases/classification/pass-values_should_match_exactly_if_lightweight_classifications_are_used.ids) - [Sample IFC: 5](testcases/classification/pass-values_should_match_exactly_if_lightweight_classifications_are_used.ifc)

## [PASS] Values match subreferences if full classifications are used (e.g. EF_25_10 should match EF_25_10_25, EF_25_10_30, etc)

~~~xml
<classification maxOccurs="unbounded" minOccurs="1">
  <value>
    <simpleValue>2</simpleValue>
  </value>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCWALL('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#5=IFCSLAB('0BbkGoC6vPvRW13UT7D8zH',$,$,$,$,$,$,$,$);
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,(#5),#6);
#8=IFCCOLUMN('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('0WTUhjMwvT39YBFH2pryoM',$,$,$,(#8),#9);
#11=IFCBEAM('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$); /* Testcase */
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('2jG7cjHsrIUfgKVktNgbzi',$,$,$,(#11),#12);
#16=IFCMATERIAL('Material',$,$);
#17=IFCEXTERNALREFERENCERELATIONSHIP($,$,#6,(#16));
~~~

[Sample IDS](testcases/classification/pass-values_match_subreferences_if_full_classifications_are_used__e_g__ef_25_10_should_match_ef_25_10_25__ef_25_10_30__etc_.ids) - [Sample IFC: 11](testcases/classification/pass-values_match_subreferences_if_full_classifications_are_used__e_g__ef_25_10_should_match_ef_25_10_25__ef_25_10_30__etc_.ifc)

## [PASS] Non-rooted resources that have external classification references should also pass

~~~xml
<classification maxOccurs="unbounded" minOccurs="1">
  <value>
    <simpleValue>1</simpleValue>
  </value>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCWALL('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#5=IFCSLAB('0BbkGoC6vPvRW13UT7D8zH',$,$,$,$,$,$,$,$);
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,(#5),#6);
#8=IFCCOLUMN('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('0WTUhjMwvT39YBFH2pryoM',$,$,$,(#8),#9);
#11=IFCBEAM('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('2jG7cjHsrIUfgKVktNgbzi',$,$,$,(#11),#12);
#16=IFCMATERIAL('Material',$,$); /* Testcase */
#17=IFCEXTERNALREFERENCERELATIONSHIP($,$,#6,(#16));
~~~

[Sample IDS](testcases/classification/pass-non_rooted_resources_that_have_external_classification_references_should_also_pass.ids) - [Sample IFC: 16](testcases/classification/pass-non_rooted_resources_that_have_external_classification_references_should_also_pass.ifc)

## [PASS] Systems should match exactly 1/5

~~~xml
<classification maxOccurs="unbounded" minOccurs="1">
  <system>
    <simpleValue>Foobar</simpleValue>
  </system>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCWALL('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#5=IFCSLAB('0BbkGoC6vPvRW13UT7D8zH',$,$,$,$,$,$,$,$);
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,(#5),#6);
#8=IFCCOLUMN('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('0WTUhjMwvT39YBFH2pryoM',$,$,$,(#8),#9);
#11=IFCBEAM('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('2jG7cjHsrIUfgKVktNgbzi',$,$,$,(#11),#12);
#16=IFCMATERIAL('Material',$,$);
#17=IFCEXTERNALREFERENCERELATIONSHIP($,$,#6,(#16));
~~~

[Sample IDS](testcases/classification/pass-systems_should_match_exactly_1_5.ids) - [Sample IFC: 1](testcases/classification/pass-systems_should_match_exactly_1_5.ifc)

## [FAIL] Systems should match exactly 2/5

~~~xml
<classification maxOccurs="unbounded" minOccurs="1">
  <system>
    <simpleValue>Foobar</simpleValue>
  </system>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCWALL('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$); /* Testcase */
#5=IFCSLAB('0BbkGoC6vPvRW13UT7D8zH',$,$,$,$,$,$,$,$);
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,(#5),#6);
#8=IFCCOLUMN('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('0WTUhjMwvT39YBFH2pryoM',$,$,$,(#8),#9);
#11=IFCBEAM('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('2jG7cjHsrIUfgKVktNgbzi',$,$,$,(#11),#12);
#16=IFCMATERIAL('Material',$,$);
#17=IFCEXTERNALREFERENCERELATIONSHIP($,$,#6,(#16));
~~~

[Sample IDS](testcases/classification/fail-systems_should_match_exactly_2_5.ids) - [Sample IFC: 4](testcases/classification/fail-systems_should_match_exactly_2_5.ifc)

## [PASS] Systems should match exactly 3/5

~~~xml
<classification maxOccurs="unbounded" minOccurs="1">
  <system>
    <simpleValue>Foobar</simpleValue>
  </system>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCWALL('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#5=IFCSLAB('0BbkGoC6vPvRW13UT7D8zH',$,$,$,$,$,$,$,$); /* Testcase */
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,(#5),#6);
#8=IFCCOLUMN('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('0WTUhjMwvT39YBFH2pryoM',$,$,$,(#8),#9);
#11=IFCBEAM('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('2jG7cjHsrIUfgKVktNgbzi',$,$,$,(#11),#12);
#16=IFCMATERIAL('Material',$,$);
#17=IFCEXTERNALREFERENCERELATIONSHIP($,$,#6,(#16));
~~~

[Sample IDS](testcases/classification/pass-systems_should_match_exactly_3_5.ids) - [Sample IFC: 5](testcases/classification/pass-systems_should_match_exactly_3_5.ifc)

## [PASS] Systems should match exactly 4/5

~~~xml
<classification maxOccurs="unbounded" minOccurs="1">
  <system>
    <simpleValue>Foobar</simpleValue>
  </system>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCWALL('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#5=IFCSLAB('0BbkGoC6vPvRW13UT7D8zH',$,$,$,$,$,$,$,$);
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,(#5),#6);
#8=IFCCOLUMN('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$); /* Testcase */
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('0WTUhjMwvT39YBFH2pryoM',$,$,$,(#8),#9);
#11=IFCBEAM('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('2jG7cjHsrIUfgKVktNgbzi',$,$,$,(#11),#12);
#16=IFCMATERIAL('Material',$,$);
#17=IFCEXTERNALREFERENCERELATIONSHIP($,$,#6,(#16));
~~~

[Sample IDS](testcases/classification/pass-systems_should_match_exactly_4_5.ids) - [Sample IFC: 8](testcases/classification/pass-systems_should_match_exactly_4_5.ifc)

## [PASS] Systems should match exactly 5/5

~~~xml
<classification maxOccurs="unbounded" minOccurs="1">
  <system>
    <simpleValue>Foobar</simpleValue>
  </system>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCWALL('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#5=IFCSLAB('0BbkGoC6vPvRW13UT7D8zH',$,$,$,$,$,$,$,$);
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,(#5),#6);
#8=IFCCOLUMN('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('0WTUhjMwvT39YBFH2pryoM',$,$,$,(#8),#9);
#11=IFCBEAM('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$); /* Testcase */
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('2jG7cjHsrIUfgKVktNgbzi',$,$,$,(#11),#12);
#16=IFCMATERIAL('Material',$,$);
#17=IFCEXTERNALREFERENCERELATIONSHIP($,$,#6,(#16));
~~~

[Sample IDS](testcases/classification/pass-systems_should_match_exactly_5_5.ids) - [Sample IFC: 11](testcases/classification/pass-systems_should_match_exactly_5_5.ifc)

## [PASS] Restrictions can be used for values 1/3

~~~xml
<classification maxOccurs="unbounded" minOccurs="1">
  <value>
    <xs:restriction base="xs:string">
      <xs:pattern value="1.*"/>
    </xs:restriction>
  </value>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCWALL('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#5=IFCSLAB('0BbkGoC6vPvRW13UT7D8zH',$,$,$,$,$,$,$,$); /* Testcase */
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,(#5),#6);
#8=IFCCOLUMN('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('0WTUhjMwvT39YBFH2pryoM',$,$,$,(#8),#9);
#11=IFCBEAM('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('2jG7cjHsrIUfgKVktNgbzi',$,$,$,(#11),#12);
#16=IFCMATERIAL('Material',$,$);
#17=IFCEXTERNALREFERENCERELATIONSHIP($,$,#6,(#16));
~~~

[Sample IDS](testcases/classification/pass-restrictions_can_be_used_for_values_1_3.ids) - [Sample IFC: 5](testcases/classification/pass-restrictions_can_be_used_for_values_1_3.ifc)

## [PASS] Restrictions can be used for values 2/3

~~~xml
<classification maxOccurs="unbounded" minOccurs="1">
  <value>
    <xs:restriction base="xs:string">
      <xs:pattern value="1.*"/>
    </xs:restriction>
  </value>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCWALL('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#5=IFCSLAB('0BbkGoC6vPvRW13UT7D8zH',$,$,$,$,$,$,$,$);
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,(#5),#6);
#8=IFCCOLUMN('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$); /* Testcase */
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('0WTUhjMwvT39YBFH2pryoM',$,$,$,(#8),#9);
#11=IFCBEAM('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('2jG7cjHsrIUfgKVktNgbzi',$,$,$,(#11),#12);
#16=IFCMATERIAL('Material',$,$);
#17=IFCEXTERNALREFERENCERELATIONSHIP($,$,#6,(#16));
~~~

[Sample IDS](testcases/classification/pass-restrictions_can_be_used_for_values_2_3.ids) - [Sample IFC: 8](testcases/classification/pass-restrictions_can_be_used_for_values_2_3.ifc)

## [FAIL] Restrictions can be used for values 3/3

~~~xml
<classification maxOccurs="unbounded" minOccurs="1">
  <value>
    <xs:restriction base="xs:string">
      <xs:pattern value="1.*"/>
    </xs:restriction>
  </value>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCWALL('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#5=IFCSLAB('0BbkGoC6vPvRW13UT7D8zH',$,$,$,$,$,$,$,$);
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,(#5),#6);
#8=IFCCOLUMN('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('0WTUhjMwvT39YBFH2pryoM',$,$,$,(#8),#9);
#11=IFCBEAM('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$); /* Testcase */
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('2jG7cjHsrIUfgKVktNgbzi',$,$,$,(#11),#12);
#16=IFCMATERIAL('Material',$,$);
#17=IFCEXTERNALREFERENCERELATIONSHIP($,$,#6,(#16));
~~~

[Sample IDS](testcases/classification/fail-restrictions_can_be_used_for_values_3_3.ids) - [Sample IFC: 11](testcases/classification/fail-restrictions_can_be_used_for_values_3_3.ifc)

## [FAIL] Restrictions can be used for systems 1/2

~~~xml
<classification maxOccurs="unbounded" minOccurs="1">
  <system>
    <xs:restriction base="xs:string">
      <xs:pattern value="Foo.*"/>
    </xs:restriction>
  </system>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCWALL('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$); /* Testcase */
#5=IFCSLAB('0BbkGoC6vPvRW13UT7D8zH',$,$,$,$,$,$,$,$);
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,(#5),#6);
#8=IFCCOLUMN('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('0WTUhjMwvT39YBFH2pryoM',$,$,$,(#8),#9);
#11=IFCBEAM('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('2jG7cjHsrIUfgKVktNgbzi',$,$,$,(#11),#12);
#16=IFCMATERIAL('Material',$,$);
#17=IFCEXTERNALREFERENCERELATIONSHIP($,$,#6,(#16));
~~~

[Sample IDS](testcases/classification/fail-restrictions_can_be_used_for_systems_1_2.ids) - [Sample IFC: 4](testcases/classification/fail-restrictions_can_be_used_for_systems_1_2.ifc)

## [PASS] Restrictions can be used for systems 2/2

~~~xml
<classification maxOccurs="unbounded" minOccurs="1">
  <system>
    <xs:restriction base="xs:string">
      <xs:pattern value="Foo.*"/>
    </xs:restriction>
  </system>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCWALL('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#5=IFCSLAB('0BbkGoC6vPvRW13UT7D8zH',$,$,$,$,$,$,$,$); /* Testcase */
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,(#5),#6);
#8=IFCCOLUMN('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('0WTUhjMwvT39YBFH2pryoM',$,$,$,(#8),#9);
#11=IFCBEAM('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('2jG7cjHsrIUfgKVktNgbzi',$,$,$,(#11),#12);
#16=IFCMATERIAL('Material',$,$);
#17=IFCEXTERNALREFERENCERELATIONSHIP($,$,#6,(#16));
~~~

[Sample IDS](testcases/classification/pass-restrictions_can_be_used_for_systems_2_2.ids) - [Sample IFC: 5](testcases/classification/pass-restrictions_can_be_used_for_systems_2_2.ifc)

## [PASS] Both system and value must match (all, not any) if specified 1/2

~~~xml
<classification maxOccurs="unbounded" minOccurs="1">
  <value>
    <simpleValue>1</simpleValue>
  </value>
  <system>
    <simpleValue>Foobar</simpleValue>
  </system>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCWALL('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#5=IFCSLAB('0BbkGoC6vPvRW13UT7D8zH',$,$,$,$,$,$,$,$); /* Testcase */
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,(#5),#6);
#8=IFCCOLUMN('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('0WTUhjMwvT39YBFH2pryoM',$,$,$,(#8),#9);
#11=IFCBEAM('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('2jG7cjHsrIUfgKVktNgbzi',$,$,$,(#11),#12);
#16=IFCMATERIAL('Material',$,$);
#17=IFCEXTERNALREFERENCERELATIONSHIP($,$,#6,(#16));
~~~

[Sample IDS](testcases/classification/pass-both_system_and_value_must_match__all__not_any__if_specified_1_2.ids) - [Sample IFC: 5](testcases/classification/pass-both_system_and_value_must_match__all__not_any__if_specified_1_2.ifc)

## [FAIL] Both system and value must match (all, not any) if specified 2/2

~~~xml
<classification maxOccurs="unbounded" minOccurs="1">
  <value>
    <simpleValue>1</simpleValue>
  </value>
  <system>
    <simpleValue>Foobar</simpleValue>
  </system>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCWALL('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#5=IFCSLAB('0BbkGoC6vPvRW13UT7D8zH',$,$,$,$,$,$,$,$);
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,(#5),#6);
#8=IFCCOLUMN('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$); /* Testcase */
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('0WTUhjMwvT39YBFH2pryoM',$,$,$,(#8),#9);
#11=IFCBEAM('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('2jG7cjHsrIUfgKVktNgbzi',$,$,$,(#11),#12);
#16=IFCMATERIAL('Material',$,$);
#17=IFCEXTERNALREFERENCERELATIONSHIP($,$,#6,(#16));
~~~

[Sample IDS](testcases/classification/fail-both_system_and_value_must_match__all__not_any__if_specified_2_2.ids) - [Sample IFC: 8](testcases/classification/fail-both_system_and_value_must_match__all__not_any__if_specified_2_2.ifc)

## [PASS] Occurrences override the type classification per system 1/3

~~~xml
<classification maxOccurs="unbounded" minOccurs="1">
  <value>
    <simpleValue>11</simpleValue>
  </value>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCWALL('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#5=IFCSLAB('0BbkGoC6vPvRW13UT7D8zH',$,$,$,$,$,$,$,$);
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,(#5),#6);
#8=IFCCOLUMN('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('0WTUhjMwvT39YBFH2pryoM',$,$,$,(#18,#8),#9);
#11=IFCBEAM('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('2jG7cjHsrIUfgKVktNgbzi',$,$,$,(#19,#11),#12);
#16=IFCMATERIAL('Material',$,$);
#17=IFCEXTERNALREFERENCERELATIONSHIP($,$,#6,(#16));
#18=IFCWALL('3qs_CEYznSwfyPnfvmY$jn',$,$,$,$,$,$,$,$); /* Testcase */
#19=IFCWALLTYPE('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$,.NOTDEFINED.);
#20=IFCRELDEFINESBYTYPE('3NmyAazpzLq8cIG7JPLlM9',$,$,$,(#18),#19);
#21=IFCCLASSIFICATION($,$,$,'Foobaz',$,$,$);
#22=IFCRELASSOCIATESCLASSIFICATION('25g_sgGv1Ktw1yG4pu$Q5F',$,$,$,(#1),#21);
#23=IFCCLASSIFICATIONREFERENCE($,'X',$,#21,$,$);
#24=IFCRELASSOCIATESCLASSIFICATION('21nBfU8VHIqvcR36t_P1iE',$,$,$,(#19),#23);
~~~

[Sample IDS](testcases/classification/pass-occurrences_override_the_type_classification_per_system_1_3.ids) - [Sample IFC: 18](testcases/classification/pass-occurrences_override_the_type_classification_per_system_1_3.ifc)

## [FAIL] Occurrences override the type classification per system 2/3

~~~xml
<classification maxOccurs="unbounded" minOccurs="1">
  <value>
    <simpleValue>22</simpleValue>
  </value>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCWALL('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#5=IFCSLAB('0BbkGoC6vPvRW13UT7D8zH',$,$,$,$,$,$,$,$);
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,(#5),#6);
#8=IFCCOLUMN('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('0WTUhjMwvT39YBFH2pryoM',$,$,$,(#18,#8),#9);
#11=IFCBEAM('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('2jG7cjHsrIUfgKVktNgbzi',$,$,$,(#19,#11),#12);
#16=IFCMATERIAL('Material',$,$);
#17=IFCEXTERNALREFERENCERELATIONSHIP($,$,#6,(#16));
#18=IFCWALL('3qs_CEYznSwfyPnfvmY$jn',$,$,$,$,$,$,$,$); /* Testcase */
#19=IFCWALLTYPE('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$,.NOTDEFINED.);
#20=IFCRELDEFINESBYTYPE('3NmyAazpzLq8cIG7JPLlM9',$,$,$,(#18),#19);
#21=IFCCLASSIFICATION($,$,$,'Foobaz',$,$,$);
#22=IFCRELASSOCIATESCLASSIFICATION('25g_sgGv1Ktw1yG4pu$Q5F',$,$,$,(#1),#21);
#23=IFCCLASSIFICATIONREFERENCE($,'X',$,#21,$,$);
#24=IFCRELASSOCIATESCLASSIFICATION('21nBfU8VHIqvcR36t_P1iE',$,$,$,(#19),#23);
~~~

[Sample IDS](testcases/classification/fail-occurrences_override_the_type_classification_per_system_2_3.ids) - [Sample IFC: 18](testcases/classification/fail-occurrences_override_the_type_classification_per_system_2_3.ifc)

## [PASS] Occurrences override the type classification per system 3/3

~~~xml
<classification maxOccurs="unbounded" minOccurs="1">
  <value>
    <simpleValue>X</simpleValue>
  </value>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCWALL('3Agm079vPIYBL4JExVrhD5',$,$,$,$,$,$,$,$);
#5=IFCSLAB('0BbkGoC6vPvRW13UT7D8zH',$,$,$,$,$,$,$,$);
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,(#5),#6);
#8=IFCCOLUMN('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('0WTUhjMwvT39YBFH2pryoM',$,$,$,(#18,#8),#9);
#11=IFCBEAM('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('2jG7cjHsrIUfgKVktNgbzi',$,$,$,(#19,#11),#12);
#16=IFCMATERIAL('Material',$,$);
#17=IFCEXTERNALREFERENCERELATIONSHIP($,$,#6,(#16));
#18=IFCWALL('3qs_CEYznSwfyPnfvmY$jn',$,$,$,$,$,$,$,$); /* Testcase */
#19=IFCWALLTYPE('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$,.NOTDEFINED.);
#20=IFCRELDEFINESBYTYPE('3NmyAazpzLq8cIG7JPLlM9',$,$,$,(#18),#19);
#21=IFCCLASSIFICATION($,$,$,'Foobaz',$,$,$);
#22=IFCRELASSOCIATESCLASSIFICATION('25g_sgGv1Ktw1yG4pu$Q5F',$,$,$,(#1),#21);
#23=IFCCLASSIFICATIONREFERENCE($,'X',$,#21,$,$);
#24=IFCRELASSOCIATESCLASSIFICATION('21nBfU8VHIqvcR36t_P1iE',$,$,$,(#19),#23);
~~~

[Sample IDS](testcases/classification/pass-occurrences_override_the_type_classification_per_system_3_3.ids) - [Sample IFC: 18](testcases/classification/pass-occurrences_override_the_type_classification_per_system_3_3.ifc)


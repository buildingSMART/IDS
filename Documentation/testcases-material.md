# Material testcases

These testcases are designed to help describe behaviour in edge cases and ambiguities. All valid IDS implementations must demonstrate identical behaviour to these test cases.

## [FAIL] Elements without a material always fail

~~~xml
<material minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/material/fail-elements_without_a_material_always_fail.ids) - [Sample IFC: 1](testcases/material/fail-elements_without_a_material_always_fail.ifc)

## [PASS] Elements with any material will pass an empty material facet

~~~xml
<material minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIAL('Unnamed',$,$);
#3=IFCRELASSOCIATESMATERIAL('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
~~~

[Sample IDS](testcases/material/pass-elements_with_any_material_will_pass_an_empty_material_facet.ids) - [Sample IFC: 1](testcases/material/pass-elements_with_any_material_will_pass_an_empty_material_facet.ifc)

## [PASS] A required facet checks all parameters as normal

~~~xml
<material minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIAL('Unnamed',$,$);
#3=IFCRELASSOCIATESMATERIAL('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
~~~

[Sample IDS](testcases/material/pass-a_required_facet_checks_all_parameters_as_normal.ids) - [Sample IFC: 1](testcases/material/pass-a_required_facet_checks_all_parameters_as_normal.ifc)

## [FAIL] A prohibited facet returns the opposite of a required facet

~~~xml
<material minOccurs="0" maxOccurs="0"/>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIAL('Unnamed',$,$);
#3=IFCRELASSOCIATESMATERIAL('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
~~~

[Sample IDS](testcases/material/fail-a_prohibited_facet_returns_the_opposite_of_a_required_facet.ids) - [Sample IFC: 1](testcases/material/fail-a_prohibited_facet_returns_the_opposite_of_a_required_facet.ifc)

## [PASS] An optional facet always passes regardless of outcome 1/2

~~~xml
<material minOccurs="0" maxOccurs="1"/>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIAL('Unnamed',$,$);
#3=IFCRELASSOCIATESMATERIAL('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
~~~

[Sample IDS](testcases/material/pass-an_optional_facet_always_passes_regardless_of_outcome_1_2.ids) - [Sample IFC: 1](testcases/material/pass-an_optional_facet_always_passes_regardless_of_outcome_1_2.ifc)

## [PASS] An optional facet always passes regardless of outcome 1/2

~~~xml
<material minOccurs="0" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIAL('Unnamed',$,$);
#3=IFCRELASSOCIATESMATERIAL('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
~~~

[Sample IDS](testcases/material/pass-an_optional_facet_always_passes_regardless_of_outcome_1_2.ids) - [Sample IFC: 1](testcases/material/pass-an_optional_facet_always_passes_regardless_of_outcome_1_2.ifc)

## [PASS] A material name may pass the value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIAL('Foo',$,$);
#3=IFCRELASSOCIATESMATERIAL('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
~~~

[Sample IDS](testcases/material/pass-a_material_name_may_pass_the_value_check.ids) - [Sample IFC: 1](testcases/material/pass-a_material_name_may_pass_the_value_check.ifc)

## [PASS] A material category may pass the value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIAL('Bar',$,'Foo');
#3=IFCRELASSOCIATESMATERIAL('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
~~~

[Sample IDS](testcases/material/pass-a_material_category_may_pass_the_value_check.ids) - [Sample IFC: 1](testcases/material/pass-a_material_category_may_pass_the_value_check.ifc)

## [PASS] Any material Name in a list will pass a value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIALLIST((#4));
#3=IFCRELASSOCIATESMATERIAL('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCMATERIAL('Foo',$,$);
~~~

[Sample IDS](testcases/material/pass-any_material_name_in_a_list_will_pass_a_value_check.ids) - [Sample IFC: 1](testcases/material/pass-any_material_name_in_a_list_will_pass_a_value_check.ifc)

## [PASS] Any material Category in a list will pass a value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIALLIST((#4));
#3=IFCRELASSOCIATESMATERIAL('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCMATERIAL('Bar',$,'Foo');
~~~

[Sample IDS](testcases/material/pass-any_material_category_in_a_list_will_pass_a_value_check.ids) - [Sample IFC: 1](testcases/material/pass-any_material_category_in_a_list_will_pass_a_value_check.ifc)

## [PASS] Any layer Name in a layer set will pass a value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIALLAYERSET((#5),'Unnamed',$);
#3=IFCRELASSOCIATESMATERIAL('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCMATERIAL('Unnamed',$,$);
#5=IFCMATERIALLAYER(#4,1.,$,'Foo',$,$,$);
~~~

[Sample IDS](testcases/material/pass-any_layer_name_in_a_layer_set_will_pass_a_value_check.ids) - [Sample IFC: 1](testcases/material/pass-any_layer_name_in_a_layer_set_will_pass_a_value_check.ifc)

## [PASS] Any layer Category in a layer set will pass a value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIALLAYERSET((#5),'Unnamed',$);
#3=IFCRELASSOCIATESMATERIAL('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCMATERIAL('Unnamed',$,$);
#5=IFCMATERIALLAYER(#4,1.,$,'Bar',$,'Foo',$);
~~~

[Sample IDS](testcases/material/pass-any_layer_category_in_a_layer_set_will_pass_a_value_check.ids) - [Sample IFC: 1](testcases/material/pass-any_layer_category_in_a_layer_set_will_pass_a_value_check.ifc)

## [PASS] Any material Name in a layer set will pass a value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIALLAYERSET((#5),'Unnamed',$);
#3=IFCRELASSOCIATESMATERIAL('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCMATERIAL('Foo',$,$);
#5=IFCMATERIALLAYER(#4,1.,$,'Bar',$,'Bar',$);
~~~

[Sample IDS](testcases/material/pass-any_material_name_in_a_layer_set_will_pass_a_value_check.ids) - [Sample IFC: 1](testcases/material/pass-any_material_name_in_a_layer_set_will_pass_a_value_check.ifc)

## [PASS] Any material Category in a layer set will pass a value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIALLAYERSET((#5),'Unnamed',$);
#3=IFCRELASSOCIATESMATERIAL('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCMATERIAL('Bar',$,'Foo');
#5=IFCMATERIALLAYER(#4,1.,$,'Bar',$,'Bar',$);
~~~

[Sample IDS](testcases/material/pass-any_material_category_in_a_layer_set_will_pass_a_value_check.ids) - [Sample IFC: 1](testcases/material/pass-any_material_category_in_a_layer_set_will_pass_a_value_check.ifc)

## [PASS] Any profile Name in a profile set will pass a value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIALPROFILESET('Unnamed',$,(#5),$);
#3=IFCRELASSOCIATESMATERIAL('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCMATERIAL('Unnamed',$,$);
#5=IFCMATERIALPROFILE('Foo',$,#4,#6,$,$);
#6=IFCCIRCLEPROFILEDEF(.AREA.,$,$,1.);
~~~

[Sample IDS](testcases/material/pass-any_profile_name_in_a_profile_set_will_pass_a_value_check.ids) - [Sample IFC: 1](testcases/material/pass-any_profile_name_in_a_profile_set_will_pass_a_value_check.ifc)

## [PASS] Any profile Category in a profile set will pass a value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIALPROFILESET('Unnamed',$,(#5),$);
#3=IFCRELASSOCIATESMATERIAL('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCMATERIAL('Unnamed',$,$);
#5=IFCMATERIALPROFILE('Bar',$,#4,#6,$,'Foo');
#6=IFCCIRCLEPROFILEDEF(.AREA.,$,$,1.);
~~~

[Sample IDS](testcases/material/pass-any_profile_category_in_a_profile_set_will_pass_a_value_check.ids) - [Sample IFC: 1](testcases/material/pass-any_profile_category_in_a_profile_set_will_pass_a_value_check.ifc)

## [PASS] Any material Name in a profile set will pass a value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIALPROFILESET('Unnamed',$,(#5),$);
#3=IFCRELASSOCIATESMATERIAL('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCMATERIAL('Foo',$,$);
#5=IFCMATERIALPROFILE('Bar',$,#4,#6,$,'Bar');
#6=IFCCIRCLEPROFILEDEF(.AREA.,$,$,1.);
~~~

[Sample IDS](testcases/material/pass-any_material_name_in_a_profile_set_will_pass_a_value_check.ids) - [Sample IFC: 1](testcases/material/pass-any_material_name_in_a_profile_set_will_pass_a_value_check.ifc)

## [PASS] Any material category in a profile set will pass a value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIALPROFILESET('Unnamed',$,(#5),$);
#3=IFCRELASSOCIATESMATERIAL('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCMATERIAL('Bar',$,'Foo');
#5=IFCMATERIALPROFILE('Bar',$,#4,#6,$,'Bar');
#6=IFCCIRCLEPROFILEDEF(.AREA.,$,$,1.);
~~~

[Sample IDS](testcases/material/pass-any_material_category_in_a_profile_set_will_pass_a_value_check.ids) - [Sample IFC: 1](testcases/material/pass-any_material_category_in_a_profile_set_will_pass_a_value_check.ifc)

## [FAIL] A constituent set with no data will fail a value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIALCONSTITUENTSET('Unnamed',$,$);
#3=IFCRELASSOCIATESMATERIAL('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
~~~

[Sample IDS](testcases/material/fail-a_constituent_set_with_no_data_will_fail_a_value_check.ids) - [Sample IFC: 1](testcases/material/fail-a_constituent_set_with_no_data_will_fail_a_value_check.ifc)

## [PASS] Any constituent Name in a constituent set will pass a value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIALCONSTITUENTSET('Unnamed',$,(#5));
#3=IFCRELASSOCIATESMATERIAL('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCMATERIAL('Unnamed',$,$);
#5=IFCMATERIALCONSTITUENT('Foo',$,#4,$,$);
~~~

[Sample IDS](testcases/material/pass-any_constituent_name_in_a_constituent_set_will_pass_a_value_check.ids) - [Sample IFC: 1](testcases/material/pass-any_constituent_name_in_a_constituent_set_will_pass_a_value_check.ifc)

## [PASS] Any constituent Category in a constituent set will pass a value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIALCONSTITUENTSET('Unnamed',$,(#5));
#3=IFCRELASSOCIATESMATERIAL('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCMATERIAL('Unnamed',$,$);
#5=IFCMATERIALCONSTITUENT('Bar',$,#4,$,'Foo');
~~~

[Sample IDS](testcases/material/pass-any_constituent_category_in_a_constituent_set_will_pass_a_value_check.ids) - [Sample IFC: 1](testcases/material/pass-any_constituent_category_in_a_constituent_set_will_pass_a_value_check.ifc)

## [PASS] Any material Name in a constituent set will pass a value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIALCONSTITUENTSET('Unnamed',$,(#5));
#3=IFCRELASSOCIATESMATERIAL('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCMATERIAL('Foo',$,$);
#5=IFCMATERIALCONSTITUENT('Bar',$,#4,$,'Bar');
~~~

[Sample IDS](testcases/material/pass-any_material_name_in_a_constituent_set_will_pass_a_value_check.ids) - [Sample IFC: 1](testcases/material/pass-any_material_name_in_a_constituent_set_will_pass_a_value_check.ifc)

## [PASS] Any material Category in a constituent set will pass a value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIALCONSTITUENTSET('Unnamed',$,(#5));
#3=IFCRELASSOCIATESMATERIAL('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCMATERIAL('Bar',$,'Foo');
#5=IFCMATERIALCONSTITUENT('Bar',$,#4,$,'Bar');
~~~

[Sample IDS](testcases/material/pass-any_material_category_in_a_constituent_set_will_pass_a_value_check.ids) - [Sample IFC: 1](testcases/material/pass-any_material_category_in_a_constituent_set_will_pass_a_value_check.ifc)

## [PASS] Occurrences can inherit materials from their types

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCWALLTYPE('0eA6m4fELI9QBIhP3wiLAp',$,$,$,$,$,$,$,$,.ELEMENTEDWALL.);
#3=IFCRELDEFINESBYTYPE('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCMATERIAL('Foo',$,$);
#5=IFCRELASSOCIATESMATERIAL('0BbkGoC6vPvRW13UT7D8zH',$,$,$,(#2),#4);
~~~

[Sample IDS](testcases/material/pass-occurrences_can_inherit_materials_from_their_types.ids) - [Sample IFC: 1](testcases/material/pass-occurrences_can_inherit_materials_from_their_types.ifc)

## [PASS] Occurrences can override materials from their types

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCWALLTYPE('0eA6m4fELI9QBIhP3wiLAp',$,$,$,$,$,$,$,$,.ELEMENTEDWALL.);
#3=IFCRELDEFINESBYTYPE('05rScmOVzMoQXOfbYdtLYj',$,$,$,(#1),#2);
#4=IFCMATERIAL('Bar',$,$);
#5=IFCRELASSOCIATESMATERIAL('0BbkGoC6vPvRW13UT7D8zH',$,$,$,(#2),#4);
#6=IFCMATERIAL('Foo',$,$);
#7=IFCRELASSOCIATESMATERIAL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,(#1),#6);
~~~

[Sample IDS](testcases/material/pass-occurrences_can_override_materials_from_their_types.ids) - [Sample IFC: 1](testcases/material/pass-occurrences_can_override_materials_from_their_types.ifc)


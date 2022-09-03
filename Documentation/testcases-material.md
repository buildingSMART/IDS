# Material testcases

These testcases are designed to help describe behaviour in edge cases and ambiguities. All valid IDS implementations must demonstrate identical behaviour to these test cases.

## [FAIL] Elements without a material always fail

~~~xml
<material minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCWALL('3b4N11kzL6dQYj15tcJ4Ck',$,$,$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/fail-elements_without_a_material_always_fail.ids) - [Sample IFC: 1](testcases/fail-elements_without_a_material_always_fail.ifc)

## [PASS] Elements with any material will pass an empty material facet

~~~xml
<material minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCWALL('3b4N11kzL6dQYj15tcJ4Ck',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIAL('Unnamed',$,$);
#3=IFCRELASSOCIATESMATERIAL('3LAP7vmC1FyRerfvSIsiOH',$,$,$,(#1),#2);
~~~

[Sample IDS](testcases/pass-elements_with_any_material_will_pass_an_empty_material_facet.ids) - [Sample IFC: 1](testcases/pass-elements_with_any_material_will_pass_an_empty_material_facet.ifc)

## [FAIL] Material with no data will fail a value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('1em2VWxjf4zxD7PPG$LyES',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIAL('Unnamed',$,$);
#3=IFCRELASSOCIATESMATERIAL('3lmYeYTFLCJwGVRHp8NAr9',$,$,$,(#1),#2);
~~~

[Sample IDS](testcases/fail-material_with_no_data_will_fail_a_value_check.ids) - [Sample IFC: 1](testcases/fail-material_with_no_data_will_fail_a_value_check.ifc)

## [PASS] A material name may pass the value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('1em2VWxjf4zxD7PPG$LyES',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIAL('Foo',$,$);
#3=IFCRELASSOCIATESMATERIAL('3lmYeYTFLCJwGVRHp8NAr9',$,$,$,(#1),#2);
~~~

[Sample IDS](testcases/pass-a_material_name_may_pass_the_value_check.ids) - [Sample IFC: 1](testcases/pass-a_material_name_may_pass_the_value_check.ifc)

## [PASS] A material category may pass the value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('1em2VWxjf4zxD7PPG$LyES',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIAL('Bar',$,'Foo');
#3=IFCRELASSOCIATESMATERIAL('3lmYeYTFLCJwGVRHp8NAr9',$,$,$,(#1),#2);
~~~

[Sample IDS](testcases/pass-a_material_category_may_pass_the_value_check.ids) - [Sample IFC: 1](testcases/pass-a_material_category_may_pass_the_value_check.ifc)

## [FAIL] A material list with no data will fail a value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('1dqvUEztf3jhc6fvY3AFcb',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIALLIST((#4));
#3=IFCRELASSOCIATESMATERIAL('3_4Xvwfsf06hLK3HtrNnQu',$,$,$,(#1),#2);
#4=IFCMATERIAL('Concrete',$,'CONCRETE');
~~~

[Sample IDS](testcases/fail-a_material_list_with_no_data_will_fail_a_value_check.ids) - [Sample IFC: 1](testcases/fail-a_material_list_with_no_data_will_fail_a_value_check.ifc)

## [PASS] Any material Name in a list will pass a value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('1dqvUEztf3jhc6fvY3AFcb',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIALLIST((#4,#5));
#3=IFCRELASSOCIATESMATERIAL('3_4Xvwfsf06hLK3HtrNnQu',$,$,$,(#1),#2);
#4=IFCMATERIAL('Concrete',$,'CONCRETE');
#5=IFCMATERIAL('Foo',$,$);
~~~

[Sample IDS](testcases/pass-any_material_name_in_a_list_will_pass_a_value_check.ids) - [Sample IFC: 1](testcases/pass-any_material_name_in_a_list_will_pass_a_value_check.ifc)

## [PASS] Any material Category in a list will pass a value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('1dqvUEztf3jhc6fvY3AFcb',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIALLIST((#4,#5));
#3=IFCRELASSOCIATESMATERIAL('3_4Xvwfsf06hLK3HtrNnQu',$,$,$,(#1),#2);
#4=IFCMATERIAL('Concrete',$,'CONCRETE');
#5=IFCMATERIAL('Bar',$,'Foo');
~~~

[Sample IDS](testcases/pass-any_material_category_in_a_list_will_pass_a_value_check.ids) - [Sample IFC: 1](testcases/pass-any_material_category_in_a_list_will_pass_a_value_check.ifc)

## [PASS] Any layer Name in a layer set will pass a value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('2quRyIlUb0fPcaBukBmxJl',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIALLAYERSET((#5),'Unnamed',$);
#3=IFCRELASSOCIATESMATERIAL('0aqphv5nX4RPnWE0EEcl3_',$,$,$,(#1),#2);
#4=IFCMATERIAL('Unnamed',$,$);
#5=IFCMATERIALLAYER(#4,1.,$,'Foo',$,$,$);
~~~

[Sample IDS](testcases/pass-any_layer_name_in_a_layer_set_will_pass_a_value_check.ids) - [Sample IFC: 1](testcases/pass-any_layer_name_in_a_layer_set_will_pass_a_value_check.ifc)

## [PASS] Any layer Category in a layer set will pass a value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('2quRyIlUb0fPcaBukBmxJl',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIALLAYERSET((#5),'Unnamed',$);
#3=IFCRELASSOCIATESMATERIAL('0aqphv5nX4RPnWE0EEcl3_',$,$,$,(#1),#2);
#4=IFCMATERIAL('Unnamed',$,$);
#5=IFCMATERIALLAYER(#4,1.,$,'Bar',$,'Foo',$);
~~~

[Sample IDS](testcases/pass-any_layer_category_in_a_layer_set_will_pass_a_value_check.ids) - [Sample IFC: 1](testcases/pass-any_layer_category_in_a_layer_set_will_pass_a_value_check.ifc)

## [PASS] Any material Name in a layer set will pass a value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('2quRyIlUb0fPcaBukBmxJl',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIALLAYERSET((#5),'Unnamed',$);
#3=IFCRELASSOCIATESMATERIAL('0aqphv5nX4RPnWE0EEcl3_',$,$,$,(#1),#2);
#4=IFCMATERIAL('Foo',$,$);
#5=IFCMATERIALLAYER(#4,1.,$,'Bar',$,'Bar',$);
~~~

[Sample IDS](testcases/pass-any_material_name_in_a_layer_set_will_pass_a_value_check.ids) - [Sample IFC: 1](testcases/pass-any_material_name_in_a_layer_set_will_pass_a_value_check.ifc)

## [PASS] Any material Category in a layer set will pass a value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('2quRyIlUb0fPcaBukBmxJl',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIALLAYERSET((#5),'Unnamed',$);
#3=IFCRELASSOCIATESMATERIAL('0aqphv5nX4RPnWE0EEcl3_',$,$,$,(#1),#2);
#4=IFCMATERIAL('Bar',$,'Foo');
#5=IFCMATERIALLAYER(#4,1.,$,'Bar',$,'Bar',$);
~~~

[Sample IDS](testcases/pass-any_material_category_in_a_layer_set_will_pass_a_value_check.ids) - [Sample IFC: 1](testcases/pass-any_material_category_in_a_layer_set_will_pass_a_value_check.ifc)

## [PASS] Any profile Name in a profile set will pass a value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('1CZWmiPG95i8AwlC2QL1ZA',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIALPROFILESET('Unnamed',$,(#5),$);
#3=IFCRELASSOCIATESMATERIAL('3KD8$objHEmOWreIypgbxE',$,$,$,(#1),#2);
#4=IFCMATERIAL('Unnamed',$,$);
#5=IFCMATERIALPROFILE('Foo',$,#4,#6,$,$);
#6=IFCCIRCLEPROFILEDEF(.AREA.,$,$,1.);
~~~

[Sample IDS](testcases/pass-any_profile_name_in_a_profile_set_will_pass_a_value_check.ids) - [Sample IFC: 1](testcases/pass-any_profile_name_in_a_profile_set_will_pass_a_value_check.ifc)

## [PASS] Any profile Category in a profile set will pass a value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('1CZWmiPG95i8AwlC2QL1ZA',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIALPROFILESET('Unnamed',$,(#5),$);
#3=IFCRELASSOCIATESMATERIAL('3KD8$objHEmOWreIypgbxE',$,$,$,(#1),#2);
#4=IFCMATERIAL('Unnamed',$,$);
#5=IFCMATERIALPROFILE('Bar',$,#4,#6,$,'Foo');
#6=IFCCIRCLEPROFILEDEF(.AREA.,$,$,1.);
~~~

[Sample IDS](testcases/pass-any_profile_category_in_a_profile_set_will_pass_a_value_check.ids) - [Sample IFC: 1](testcases/pass-any_profile_category_in_a_profile_set_will_pass_a_value_check.ifc)

## [PASS] Any material Name in a profile set will pass a value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('1CZWmiPG95i8AwlC2QL1ZA',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIALPROFILESET('Unnamed',$,(#5),$);
#3=IFCRELASSOCIATESMATERIAL('3KD8$objHEmOWreIypgbxE',$,$,$,(#1),#2);
#4=IFCMATERIAL('Foo',$,$);
#5=IFCMATERIALPROFILE('Bar',$,#4,#6,$,'Bar');
#6=IFCCIRCLEPROFILEDEF(.AREA.,$,$,1.);
~~~

[Sample IDS](testcases/pass-any_material_name_in_a_profile_set_will_pass_a_value_check.ids) - [Sample IFC: 1](testcases/pass-any_material_name_in_a_profile_set_will_pass_a_value_check.ifc)

## [PASS] Any material category in a profile set will pass a value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('1CZWmiPG95i8AwlC2QL1ZA',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIALPROFILESET('Unnamed',$,(#5),$);
#3=IFCRELASSOCIATESMATERIAL('3KD8$objHEmOWreIypgbxE',$,$,$,(#1),#2);
#4=IFCMATERIAL('Bar',$,'Foo');
#5=IFCMATERIALPROFILE('Bar',$,#4,#6,$,'Bar');
#6=IFCCIRCLEPROFILEDEF(.AREA.,$,$,1.);
~~~

[Sample IDS](testcases/pass-any_material_category_in_a_profile_set_will_pass_a_value_check.ids) - [Sample IFC: 1](testcases/pass-any_material_category_in_a_profile_set_will_pass_a_value_check.ifc)

## [FAIL] A constituent set with no data will fail a value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('2oqKSSmgb4CeCgipXo778i',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIALCONSTITUENTSET('Unnamed',$,$);
#3=IFCRELASSOCIATESMATERIAL('2bvf5Lr5r1hewzJePZxXYH',$,$,$,(#1),#2);
~~~

[Sample IDS](testcases/fail-a_constituent_set_with_no_data_will_fail_a_value_check.ids) - [Sample IFC: 1](testcases/fail-a_constituent_set_with_no_data_will_fail_a_value_check.ifc)

## [PASS] Any constituent Name in a constituent set will pass a value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('2oqKSSmgb4CeCgipXo778i',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIALCONSTITUENTSET('Unnamed',$,(#5));
#3=IFCRELASSOCIATESMATERIAL('2bvf5Lr5r1hewzJePZxXYH',$,$,$,(#1),#2);
#4=IFCMATERIAL('Unnamed',$,$);
#5=IFCMATERIALCONSTITUENT('Foo',$,#4,$,$);
~~~

[Sample IDS](testcases/pass-any_constituent_name_in_a_constituent_set_will_pass_a_value_check.ids) - [Sample IFC: 1](testcases/pass-any_constituent_name_in_a_constituent_set_will_pass_a_value_check.ifc)

## [PASS] Any constituent Category in a constituent set will pass a value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('2oqKSSmgb4CeCgipXo778i',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIALCONSTITUENTSET('Unnamed',$,(#5));
#3=IFCRELASSOCIATESMATERIAL('2bvf5Lr5r1hewzJePZxXYH',$,$,$,(#1),#2);
#4=IFCMATERIAL('Unnamed',$,$);
#5=IFCMATERIALCONSTITUENT('Bar',$,#4,$,'Foo');
~~~

[Sample IDS](testcases/pass-any_constituent_category_in_a_constituent_set_will_pass_a_value_check.ids) - [Sample IFC: 1](testcases/pass-any_constituent_category_in_a_constituent_set_will_pass_a_value_check.ifc)

## [PASS] Any material Name in a constituent set will pass a value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('2oqKSSmgb4CeCgipXo778i',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIALCONSTITUENTSET('Unnamed',$,(#5));
#3=IFCRELASSOCIATESMATERIAL('2bvf5Lr5r1hewzJePZxXYH',$,$,$,(#1),#2);
#4=IFCMATERIAL('Foo',$,$);
#5=IFCMATERIALCONSTITUENT('Bar',$,#4,$,'Bar');
~~~

[Sample IDS](testcases/pass-any_material_name_in_a_constituent_set_will_pass_a_value_check.ids) - [Sample IFC: 1](testcases/pass-any_material_name_in_a_constituent_set_will_pass_a_value_check.ifc)

## [PASS] Any material Category in a constituent set will pass a value check

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('2oqKSSmgb4CeCgipXo778i',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCMATERIALCONSTITUENTSET('Unnamed',$,(#5));
#3=IFCRELASSOCIATESMATERIAL('2bvf5Lr5r1hewzJePZxXYH',$,$,$,(#1),#2);
#4=IFCMATERIAL('Bar',$,'Foo');
#5=IFCMATERIALCONSTITUENT('Bar',$,#4,$,'Bar');
~~~

[Sample IDS](testcases/pass-any_material_category_in_a_constituent_set_will_pass_a_value_check.ids) - [Sample IFC: 1](testcases/pass-any_material_category_in_a_constituent_set_will_pass_a_value_check.ifc)

## [PASS] Occurrences can inherit materials from their types

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('3vFMA9TM13SPLINaj5vzD2',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCWALLTYPE('3gYiUqnY96pAouuoWc42nv',$,$,$,$,$,$,$,$,.ELEMENTEDWALL.);
#3=IFCRELDEFINESBYTYPE('1L0PkvDRj9EvK7$HLTfQRq',$,$,$,(#1),#2);
#4=IFCMATERIAL('Foo',$,$);
#5=IFCRELASSOCIATESMATERIAL('0YDKatTqT7qRtZwgR0VIqA',$,$,$,(#2),#4);
~~~

[Sample IDS](testcases/pass-occurrences_can_inherit_materials_from_their_types.ids) - [Sample IFC: 1](testcases/pass-occurrences_can_inherit_materials_from_their_types.ifc)

## [PASS] Occurrences can override materials from their types

~~~xml
<material minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>Foo</simpleValue>
  </value>
</material>
~~~

~~~lua
#1=IFCWALL('2FMdrmuwH0CflUc2A1JDgV',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCWALLTYPE('2W6woWPnT8lBDxasNC4MLO',$,$,$,$,$,$,$,$,.ELEMENTEDWALL.);
#3=IFCRELDEFINESBYTYPE('0TpnC9_T5CauN7RO_D3M8Z',$,$,$,(#1),#2);
#4=IFCMATERIAL('Bar',$,$);
#5=IFCRELASSOCIATESMATERIAL('1uEdcqQ4bB6vFqQ7ESQ8Ys',$,$,$,(#2),#4);
#6=IFCMATERIAL('Foo',$,$);
#7=IFCRELASSOCIATESMATERIAL('0hiZvcQtb8dOB1cXGdOvST',$,$,$,(#1),#6);
~~~

[Sample IDS](testcases/pass-occurrences_can_override_materials_from_their_types.ids) - [Sample IFC: 1](testcases/pass-occurrences_can_override_materials_from_their_types.ifc)


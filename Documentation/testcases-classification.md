# Classification testcases

These testcases are designed to help describe behaviour in edge cases and ambiguities. All valid IDS implementations must demonstrate identical behaviour to these test cases.

## [FAIL] A classification facet with no data matches any classification 1/2

~~~xml
<classification minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCPROJECT('1YKJbs5jj6dh3MtS0j2OK2',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('00BJZTWcfFCg0RbkiKv1fM',$,$,$,(#1),#2);
#4=IFCWALL('2UleVhRgnCfgW5SttZE_7y',$,$,$,$,$,$,$,$); /* Testcase */
#5=IFCWALL('2W7F_ccg94rwa1nsWn0b0j',$,$,$,$,$,$,$,$);
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('3jbMAz3Of0M9$GsA4vnQIB',$,$,$,(#5),#6);
#8=IFCWALL('2jD97aGmz9kQB0ecAchgic',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('2cx4Wu97n869Aqk3DiPKpW',$,$,$,(#8),#9);
#11=IFCWALL('3O2yN0uPz5l8zU4bMKTOyE',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('3OTcVvSHf7RvGHzaEB8x6S',$,$,$,(#11),#12);
~~~

[Sample IDS](testcases/fail-a_classification_facet_with_no_data_matches_any_classification_1_2.ids) - [Sample IFC: 4](testcases/fail-a_classification_facet_with_no_data_matches_any_classification_1_2.ifc)

## [PASS] A classification facet with no data matches any classification 2/2

~~~xml
<classification minOccurs="1" maxOccurs="1"/>
~~~

~~~lua
#1=IFCPROJECT('1YKJbs5jj6dh3MtS0j2OK2',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('00BJZTWcfFCg0RbkiKv1fM',$,$,$,(#1),#2);
#4=IFCWALL('2UleVhRgnCfgW5SttZE_7y',$,$,$,$,$,$,$,$);
#5=IFCWALL('2W7F_ccg94rwa1nsWn0b0j',$,$,$,$,$,$,$,$); /* Testcase */
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('3jbMAz3Of0M9$GsA4vnQIB',$,$,$,(#5),#6);
#8=IFCWALL('2jD97aGmz9kQB0ecAchgic',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('2cx4Wu97n869Aqk3DiPKpW',$,$,$,(#8),#9);
#11=IFCWALL('3O2yN0uPz5l8zU4bMKTOyE',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('3OTcVvSHf7RvGHzaEB8x6S',$,$,$,(#11),#12);
~~~

[Sample IDS](testcases/pass-a_classification_facet_with_no_data_matches_any_classification_2_2.ids) - [Sample IFC: 5](testcases/pass-a_classification_facet_with_no_data_matches_any_classification_2_2.ifc)

## [PASS] Values should match exactly if lightweight classifications are used

~~~xml
<classification minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>1</simpleValue>
  </value>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1YKJbs5jj6dh3MtS0j2OK2',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('00BJZTWcfFCg0RbkiKv1fM',$,$,$,(#1),#2);
#4=IFCWALL('2UleVhRgnCfgW5SttZE_7y',$,$,$,$,$,$,$,$);
#5=IFCWALL('2W7F_ccg94rwa1nsWn0b0j',$,$,$,$,$,$,$,$); /* Testcase */
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('3jbMAz3Of0M9$GsA4vnQIB',$,$,$,(#5),#6);
#8=IFCWALL('2jD97aGmz9kQB0ecAchgic',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('2cx4Wu97n869Aqk3DiPKpW',$,$,$,(#8),#9);
#11=IFCWALL('3O2yN0uPz5l8zU4bMKTOyE',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('3OTcVvSHf7RvGHzaEB8x6S',$,$,$,(#11),#12);
~~~

[Sample IDS](testcases/pass-values_should_match_exactly_if_lightweight_classifications_are_used.ids) - [Sample IFC: 5](testcases/pass-values_should_match_exactly_if_lightweight_classifications_are_used.ifc)

## [PASS] Values match subreferences if full classifications are used (e.g. EF_25_10 should match EF_25_10_25, EF_25_10_30, etc)

~~~xml
<classification minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>2</simpleValue>
  </value>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1YKJbs5jj6dh3MtS0j2OK2',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('00BJZTWcfFCg0RbkiKv1fM',$,$,$,(#1),#2);
#4=IFCWALL('2UleVhRgnCfgW5SttZE_7y',$,$,$,$,$,$,$,$);
#5=IFCWALL('2W7F_ccg94rwa1nsWn0b0j',$,$,$,$,$,$,$,$);
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('3jbMAz3Of0M9$GsA4vnQIB',$,$,$,(#5),#6);
#8=IFCWALL('2jD97aGmz9kQB0ecAchgic',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('2cx4Wu97n869Aqk3DiPKpW',$,$,$,(#8),#9);
#11=IFCWALL('3O2yN0uPz5l8zU4bMKTOyE',$,$,$,$,$,$,$,$); /* Testcase */
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('3OTcVvSHf7RvGHzaEB8x6S',$,$,$,(#11),#12);
~~~

[Sample IDS](testcases/pass-values_match_subreferences_if_full_classifications_are_used__e_g__ef_25_10_should_match_ef_25_10_25__ef_25_10_30__etc_.ids) - [Sample IFC: 11](testcases/pass-values_match_subreferences_if_full_classifications_are_used__e_g__ef_25_10_should_match_ef_25_10_25__ef_25_10_30__etc_.ifc)

## [PASS] Systems should match exactly 1/5

~~~xml
<classification minOccurs="1" maxOccurs="1">
  <system>
    <simpleValue>Foobar</simpleValue>
  </system>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1YKJbs5jj6dh3MtS0j2OK2',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('00BJZTWcfFCg0RbkiKv1fM',$,$,$,(#1),#2);
#4=IFCWALL('2UleVhRgnCfgW5SttZE_7y',$,$,$,$,$,$,$,$);
#5=IFCWALL('2W7F_ccg94rwa1nsWn0b0j',$,$,$,$,$,$,$,$);
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('3jbMAz3Of0M9$GsA4vnQIB',$,$,$,(#5),#6);
#8=IFCWALL('2jD97aGmz9kQB0ecAchgic',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('2cx4Wu97n869Aqk3DiPKpW',$,$,$,(#8),#9);
#11=IFCWALL('3O2yN0uPz5l8zU4bMKTOyE',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('3OTcVvSHf7RvGHzaEB8x6S',$,$,$,(#11),#12);
~~~

[Sample IDS](testcases/pass-systems_should_match_exactly_1_5.ids) - [Sample IFC: 1](testcases/pass-systems_should_match_exactly_1_5.ifc)

## [FAIL] Systems should match exactly 2/5

~~~xml
<classification minOccurs="1" maxOccurs="1">
  <system>
    <simpleValue>Foobar</simpleValue>
  </system>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1YKJbs5jj6dh3MtS0j2OK2',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('00BJZTWcfFCg0RbkiKv1fM',$,$,$,(#1),#2);
#4=IFCWALL('2UleVhRgnCfgW5SttZE_7y',$,$,$,$,$,$,$,$); /* Testcase */
#5=IFCWALL('2W7F_ccg94rwa1nsWn0b0j',$,$,$,$,$,$,$,$);
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('3jbMAz3Of0M9$GsA4vnQIB',$,$,$,(#5),#6);
#8=IFCWALL('2jD97aGmz9kQB0ecAchgic',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('2cx4Wu97n869Aqk3DiPKpW',$,$,$,(#8),#9);
#11=IFCWALL('3O2yN0uPz5l8zU4bMKTOyE',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('3OTcVvSHf7RvGHzaEB8x6S',$,$,$,(#11),#12);
~~~

[Sample IDS](testcases/fail-systems_should_match_exactly_2_5.ids) - [Sample IFC: 4](testcases/fail-systems_should_match_exactly_2_5.ifc)

## [PASS] Systems should match exactly 3/5

~~~xml
<classification minOccurs="1" maxOccurs="1">
  <system>
    <simpleValue>Foobar</simpleValue>
  </system>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1YKJbs5jj6dh3MtS0j2OK2',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('00BJZTWcfFCg0RbkiKv1fM',$,$,$,(#1),#2);
#4=IFCWALL('2UleVhRgnCfgW5SttZE_7y',$,$,$,$,$,$,$,$);
#5=IFCWALL('2W7F_ccg94rwa1nsWn0b0j',$,$,$,$,$,$,$,$); /* Testcase */
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('3jbMAz3Of0M9$GsA4vnQIB',$,$,$,(#5),#6);
#8=IFCWALL('2jD97aGmz9kQB0ecAchgic',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('2cx4Wu97n869Aqk3DiPKpW',$,$,$,(#8),#9);
#11=IFCWALL('3O2yN0uPz5l8zU4bMKTOyE',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('3OTcVvSHf7RvGHzaEB8x6S',$,$,$,(#11),#12);
~~~

[Sample IDS](testcases/pass-systems_should_match_exactly_3_5.ids) - [Sample IFC: 5](testcases/pass-systems_should_match_exactly_3_5.ifc)

## [PASS] Systems should match exactly 4/5

~~~xml
<classification minOccurs="1" maxOccurs="1">
  <system>
    <simpleValue>Foobar</simpleValue>
  </system>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1YKJbs5jj6dh3MtS0j2OK2',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('00BJZTWcfFCg0RbkiKv1fM',$,$,$,(#1),#2);
#4=IFCWALL('2UleVhRgnCfgW5SttZE_7y',$,$,$,$,$,$,$,$);
#5=IFCWALL('2W7F_ccg94rwa1nsWn0b0j',$,$,$,$,$,$,$,$);
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('3jbMAz3Of0M9$GsA4vnQIB',$,$,$,(#5),#6);
#8=IFCWALL('2jD97aGmz9kQB0ecAchgic',$,$,$,$,$,$,$,$); /* Testcase */
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('2cx4Wu97n869Aqk3DiPKpW',$,$,$,(#8),#9);
#11=IFCWALL('3O2yN0uPz5l8zU4bMKTOyE',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('3OTcVvSHf7RvGHzaEB8x6S',$,$,$,(#11),#12);
~~~

[Sample IDS](testcases/pass-systems_should_match_exactly_4_5.ids) - [Sample IFC: 8](testcases/pass-systems_should_match_exactly_4_5.ifc)

## [PASS] Systems should match exactly 5/5

~~~xml
<classification minOccurs="1" maxOccurs="1">
  <system>
    <simpleValue>Foobar</simpleValue>
  </system>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1YKJbs5jj6dh3MtS0j2OK2',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('00BJZTWcfFCg0RbkiKv1fM',$,$,$,(#1),#2);
#4=IFCWALL('2UleVhRgnCfgW5SttZE_7y',$,$,$,$,$,$,$,$);
#5=IFCWALL('2W7F_ccg94rwa1nsWn0b0j',$,$,$,$,$,$,$,$);
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('3jbMAz3Of0M9$GsA4vnQIB',$,$,$,(#5),#6);
#8=IFCWALL('2jD97aGmz9kQB0ecAchgic',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('2cx4Wu97n869Aqk3DiPKpW',$,$,$,(#8),#9);
#11=IFCWALL('3O2yN0uPz5l8zU4bMKTOyE',$,$,$,$,$,$,$,$); /* Testcase */
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('3OTcVvSHf7RvGHzaEB8x6S',$,$,$,(#11),#12);
~~~

[Sample IDS](testcases/pass-systems_should_match_exactly_5_5.ids) - [Sample IFC: 11](testcases/pass-systems_should_match_exactly_5_5.ifc)

## [PASS] Restrictions can be used for values 1/3

~~~xml
<classification minOccurs="1" maxOccurs="1">
  <value>
    <xs:restriction base="xs:string">
      <xs:pattern value="1.*"/>
    </xs:restriction>
  </value>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1YKJbs5jj6dh3MtS0j2OK2',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('00BJZTWcfFCg0RbkiKv1fM',$,$,$,(#1),#2);
#4=IFCWALL('2UleVhRgnCfgW5SttZE_7y',$,$,$,$,$,$,$,$);
#5=IFCWALL('2W7F_ccg94rwa1nsWn0b0j',$,$,$,$,$,$,$,$); /* Testcase */
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('3jbMAz3Of0M9$GsA4vnQIB',$,$,$,(#5),#6);
#8=IFCWALL('2jD97aGmz9kQB0ecAchgic',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('2cx4Wu97n869Aqk3DiPKpW',$,$,$,(#8),#9);
#11=IFCWALL('3O2yN0uPz5l8zU4bMKTOyE',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('3OTcVvSHf7RvGHzaEB8x6S',$,$,$,(#11),#12);
~~~

[Sample IDS](testcases/pass-restrictions_can_be_used_for_values_1_3.ids) - [Sample IFC: 5](testcases/pass-restrictions_can_be_used_for_values_1_3.ifc)

## [PASS] Restrictions can be used for values 2/3

~~~xml
<classification minOccurs="1" maxOccurs="1">
  <value>
    <xs:restriction base="xs:string">
      <xs:pattern value="1.*"/>
    </xs:restriction>
  </value>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1YKJbs5jj6dh3MtS0j2OK2',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('00BJZTWcfFCg0RbkiKv1fM',$,$,$,(#1),#2);
#4=IFCWALL('2UleVhRgnCfgW5SttZE_7y',$,$,$,$,$,$,$,$);
#5=IFCWALL('2W7F_ccg94rwa1nsWn0b0j',$,$,$,$,$,$,$,$);
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('3jbMAz3Of0M9$GsA4vnQIB',$,$,$,(#5),#6);
#8=IFCWALL('2jD97aGmz9kQB0ecAchgic',$,$,$,$,$,$,$,$); /* Testcase */
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('2cx4Wu97n869Aqk3DiPKpW',$,$,$,(#8),#9);
#11=IFCWALL('3O2yN0uPz5l8zU4bMKTOyE',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('3OTcVvSHf7RvGHzaEB8x6S',$,$,$,(#11),#12);
~~~

[Sample IDS](testcases/pass-restrictions_can_be_used_for_values_2_3.ids) - [Sample IFC: 8](testcases/pass-restrictions_can_be_used_for_values_2_3.ifc)

## [FAIL] Restrictions can be used for values 3/3

~~~xml
<classification minOccurs="1" maxOccurs="1">
  <value>
    <xs:restriction base="xs:string">
      <xs:pattern value="1.*"/>
    </xs:restriction>
  </value>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1YKJbs5jj6dh3MtS0j2OK2',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('00BJZTWcfFCg0RbkiKv1fM',$,$,$,(#1),#2);
#4=IFCWALL('2UleVhRgnCfgW5SttZE_7y',$,$,$,$,$,$,$,$);
#5=IFCWALL('2W7F_ccg94rwa1nsWn0b0j',$,$,$,$,$,$,$,$);
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('3jbMAz3Of0M9$GsA4vnQIB',$,$,$,(#5),#6);
#8=IFCWALL('2jD97aGmz9kQB0ecAchgic',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('2cx4Wu97n869Aqk3DiPKpW',$,$,$,(#8),#9);
#11=IFCWALL('3O2yN0uPz5l8zU4bMKTOyE',$,$,$,$,$,$,$,$); /* Testcase */
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('3OTcVvSHf7RvGHzaEB8x6S',$,$,$,(#11),#12);
~~~

[Sample IDS](testcases/fail-restrictions_can_be_used_for_values_3_3.ids) - [Sample IFC: 11](testcases/fail-restrictions_can_be_used_for_values_3_3.ifc)

## [FAIL] Restrictions can be used for systems 1/2

~~~xml
<classification minOccurs="1" maxOccurs="1">
  <system>
    <xs:restriction base="xs:string">
      <xs:pattern value="Foo.*"/>
    </xs:restriction>
  </system>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1YKJbs5jj6dh3MtS0j2OK2',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('00BJZTWcfFCg0RbkiKv1fM',$,$,$,(#1),#2);
#4=IFCWALL('2UleVhRgnCfgW5SttZE_7y',$,$,$,$,$,$,$,$); /* Testcase */
#5=IFCWALL('2W7F_ccg94rwa1nsWn0b0j',$,$,$,$,$,$,$,$);
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('3jbMAz3Of0M9$GsA4vnQIB',$,$,$,(#5),#6);
#8=IFCWALL('2jD97aGmz9kQB0ecAchgic',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('2cx4Wu97n869Aqk3DiPKpW',$,$,$,(#8),#9);
#11=IFCWALL('3O2yN0uPz5l8zU4bMKTOyE',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('3OTcVvSHf7RvGHzaEB8x6S',$,$,$,(#11),#12);
~~~

[Sample IDS](testcases/fail-restrictions_can_be_used_for_systems_1_2.ids) - [Sample IFC: 4](testcases/fail-restrictions_can_be_used_for_systems_1_2.ifc)

## [PASS] Restrictions can be used for systems 2/2

~~~xml
<classification minOccurs="1" maxOccurs="1">
  <system>
    <xs:restriction base="xs:string">
      <xs:pattern value="Foo.*"/>
    </xs:restriction>
  </system>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1YKJbs5jj6dh3MtS0j2OK2',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('00BJZTWcfFCg0RbkiKv1fM',$,$,$,(#1),#2);
#4=IFCWALL('2UleVhRgnCfgW5SttZE_7y',$,$,$,$,$,$,$,$);
#5=IFCWALL('2W7F_ccg94rwa1nsWn0b0j',$,$,$,$,$,$,$,$); /* Testcase */
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('3jbMAz3Of0M9$GsA4vnQIB',$,$,$,(#5),#6);
#8=IFCWALL('2jD97aGmz9kQB0ecAchgic',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('2cx4Wu97n869Aqk3DiPKpW',$,$,$,(#8),#9);
#11=IFCWALL('3O2yN0uPz5l8zU4bMKTOyE',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('3OTcVvSHf7RvGHzaEB8x6S',$,$,$,(#11),#12);
~~~

[Sample IDS](testcases/pass-restrictions_can_be_used_for_systems_2_2.ids) - [Sample IFC: 5](testcases/pass-restrictions_can_be_used_for_systems_2_2.ifc)

## [PASS] Both system and value must match (all, not any) if specified 1/2

~~~xml
<classification minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>1</simpleValue>
  </value>
  <system>
    <simpleValue>Foobar</simpleValue>
  </system>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1YKJbs5jj6dh3MtS0j2OK2',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('00BJZTWcfFCg0RbkiKv1fM',$,$,$,(#1),#2);
#4=IFCWALL('2UleVhRgnCfgW5SttZE_7y',$,$,$,$,$,$,$,$);
#5=IFCWALL('2W7F_ccg94rwa1nsWn0b0j',$,$,$,$,$,$,$,$); /* Testcase */
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('3jbMAz3Of0M9$GsA4vnQIB',$,$,$,(#5),#6);
#8=IFCWALL('2jD97aGmz9kQB0ecAchgic',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('2cx4Wu97n869Aqk3DiPKpW',$,$,$,(#8),#9);
#11=IFCWALL('3O2yN0uPz5l8zU4bMKTOyE',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('3OTcVvSHf7RvGHzaEB8x6S',$,$,$,(#11),#12);
~~~

[Sample IDS](testcases/pass-both_system_and_value_must_match__all__not_any__if_specified_1_2.ids) - [Sample IFC: 5](testcases/pass-both_system_and_value_must_match__all__not_any__if_specified_1_2.ifc)

## [FAIL] Both system and value must match (all, not any) if specified 2/2

~~~xml
<classification minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>1</simpleValue>
  </value>
  <system>
    <simpleValue>Foobar</simpleValue>
  </system>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1YKJbs5jj6dh3MtS0j2OK2',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('00BJZTWcfFCg0RbkiKv1fM',$,$,$,(#1),#2);
#4=IFCWALL('2UleVhRgnCfgW5SttZE_7y',$,$,$,$,$,$,$,$);
#5=IFCWALL('2W7F_ccg94rwa1nsWn0b0j',$,$,$,$,$,$,$,$);
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('3jbMAz3Of0M9$GsA4vnQIB',$,$,$,(#5),#6);
#8=IFCWALL('2jD97aGmz9kQB0ecAchgic',$,$,$,$,$,$,$,$); /* Testcase */
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('2cx4Wu97n869Aqk3DiPKpW',$,$,$,(#8),#9);
#11=IFCWALL('3O2yN0uPz5l8zU4bMKTOyE',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('3OTcVvSHf7RvGHzaEB8x6S',$,$,$,(#11),#12);
~~~

[Sample IDS](testcases/fail-both_system_and_value_must_match__all__not_any__if_specified_2_2.ids) - [Sample IFC: 8](testcases/fail-both_system_and_value_must_match__all__not_any__if_specified_2_2.ifc)

## [PASS] Occurrences override the type classification per system 1/3

~~~xml
<classification minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>11</simpleValue>
  </value>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1YKJbs5jj6dh3MtS0j2OK2',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('00BJZTWcfFCg0RbkiKv1fM',$,$,$,(#1),#2);
#4=IFCWALL('2UleVhRgnCfgW5SttZE_7y',$,$,$,$,$,$,$,$);
#5=IFCWALL('2W7F_ccg94rwa1nsWn0b0j',$,$,$,$,$,$,$,$);
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('3jbMAz3Of0M9$GsA4vnQIB',$,$,$,(#5),#6);
#8=IFCWALL('2jD97aGmz9kQB0ecAchgic',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('2cx4Wu97n869Aqk3DiPKpW',$,$,$,(#16,#8),#9);
#11=IFCWALL('3O2yN0uPz5l8zU4bMKTOyE',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('3OTcVvSHf7RvGHzaEB8x6S',$,$,$,(#11,#17),#12);
#16=IFCWALL('3gjhpoGY54T8ZY2eLSU6Mj',$,$,$,$,$,$,$,$); /* Testcase */
#17=IFCWALLTYPE('3bLBNhMpT68fl5VCu2b9fk',$,$,$,$,$,$,$,$,.ELEMENTEDWALL.);
#18=IFCRELDEFINESBYTYPE('3iDG_WdzrCCeybZ$O3bcLV',$,$,$,(#16),#17);
#19=IFCCLASSIFICATION($,$,$,'Foobaz',$,$,$);
#20=IFCRELASSOCIATESCLASSIFICATION('3mVzrKNQHEsQ3do0idBpgM',$,$,$,(#1),#19);
#21=IFCCLASSIFICATIONREFERENCE($,'X',$,#19,$,$);
#22=IFCRELASSOCIATESCLASSIFICATION('1$lAD_gez30QRAVfOBq0DZ',$,$,$,(#17),#21);
~~~

[Sample IDS](testcases/pass-occurrences_override_the_type_classification_per_system_1_3.ids) - [Sample IFC: 16](testcases/pass-occurrences_override_the_type_classification_per_system_1_3.ifc)

## [FAIL] Occurrences override the type classification per system 2/3

~~~xml
<classification minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>22</simpleValue>
  </value>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1YKJbs5jj6dh3MtS0j2OK2',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('00BJZTWcfFCg0RbkiKv1fM',$,$,$,(#1),#2);
#4=IFCWALL('2UleVhRgnCfgW5SttZE_7y',$,$,$,$,$,$,$,$);
#5=IFCWALL('2W7F_ccg94rwa1nsWn0b0j',$,$,$,$,$,$,$,$);
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('3jbMAz3Of0M9$GsA4vnQIB',$,$,$,(#5),#6);
#8=IFCWALL('2jD97aGmz9kQB0ecAchgic',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('2cx4Wu97n869Aqk3DiPKpW',$,$,$,(#16,#8),#9);
#11=IFCWALL('3O2yN0uPz5l8zU4bMKTOyE',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('3OTcVvSHf7RvGHzaEB8x6S',$,$,$,(#11,#17),#12);
#16=IFCWALL('3gjhpoGY54T8ZY2eLSU6Mj',$,$,$,$,$,$,$,$); /* Testcase */
#17=IFCWALLTYPE('3bLBNhMpT68fl5VCu2b9fk',$,$,$,$,$,$,$,$,.ELEMENTEDWALL.);
#18=IFCRELDEFINESBYTYPE('3iDG_WdzrCCeybZ$O3bcLV',$,$,$,(#16),#17);
#19=IFCCLASSIFICATION($,$,$,'Foobaz',$,$,$);
#20=IFCRELASSOCIATESCLASSIFICATION('3mVzrKNQHEsQ3do0idBpgM',$,$,$,(#1),#19);
#21=IFCCLASSIFICATIONREFERENCE($,'X',$,#19,$,$);
#22=IFCRELASSOCIATESCLASSIFICATION('1$lAD_gez30QRAVfOBq0DZ',$,$,$,(#17),#21);
~~~

[Sample IDS](testcases/fail-occurrences_override_the_type_classification_per_system_2_3.ids) - [Sample IFC: 16](testcases/fail-occurrences_override_the_type_classification_per_system_2_3.ifc)

## [PASS] Occurrences override the type classification per system 3/3

~~~xml
<classification minOccurs="1" maxOccurs="1">
  <value>
    <simpleValue>X</simpleValue>
  </value>
</classification>
~~~

~~~lua
#1=IFCPROJECT('1YKJbs5jj6dh3MtS0j2OK2',$,$,$,$,$,$,$,$);
#2=IFCCLASSIFICATION($,$,$,'Foobar',$,$,$);
#3=IFCRELASSOCIATESCLASSIFICATION('00BJZTWcfFCg0RbkiKv1fM',$,$,$,(#1),#2);
#4=IFCWALL('2UleVhRgnCfgW5SttZE_7y',$,$,$,$,$,$,$,$);
#5=IFCWALL('2W7F_ccg94rwa1nsWn0b0j',$,$,$,$,$,$,$,$);
#6=IFCCLASSIFICATIONREFERENCE($,'1',$,#2,$,$);
#7=IFCRELASSOCIATESCLASSIFICATION('3jbMAz3Of0M9$GsA4vnQIB',$,$,$,(#5),#6);
#8=IFCWALL('2jD97aGmz9kQB0ecAchgic',$,$,$,$,$,$,$,$);
#9=IFCCLASSIFICATIONREFERENCE($,'11',$,#2,$,$);
#10=IFCRELASSOCIATESCLASSIFICATION('2cx4Wu97n869Aqk3DiPKpW',$,$,$,(#16,#8),#9);
#11=IFCWALL('3O2yN0uPz5l8zU4bMKTOyE',$,$,$,$,$,$,$,$);
#12=IFCCLASSIFICATIONREFERENCE($,'22',$,#13,$,$);
#13=IFCCLASSIFICATIONREFERENCE($,'2',$,#2,$,$);
#15=IFCRELASSOCIATESCLASSIFICATION('3OTcVvSHf7RvGHzaEB8x6S',$,$,$,(#11,#17),#12);
#16=IFCWALL('3gjhpoGY54T8ZY2eLSU6Mj',$,$,$,$,$,$,$,$); /* Testcase */
#17=IFCWALLTYPE('3bLBNhMpT68fl5VCu2b9fk',$,$,$,$,$,$,$,$,.ELEMENTEDWALL.);
#18=IFCRELDEFINESBYTYPE('3iDG_WdzrCCeybZ$O3bcLV',$,$,$,(#16),#17);
#19=IFCCLASSIFICATION($,$,$,'Foobaz',$,$,$);
#20=IFCRELASSOCIATESCLASSIFICATION('3mVzrKNQHEsQ3do0idBpgM',$,$,$,(#1),#19);
#21=IFCCLASSIFICATIONREFERENCE($,'X',$,#19,$,$);
#22=IFCRELASSOCIATESCLASSIFICATION('1$lAD_gez30QRAVfOBq0DZ',$,$,$,(#17),#21);
~~~

[Sample IDS](testcases/pass-occurrences_override_the_type_classification_per_system_3_3.ids) - [Sample IFC: 16](testcases/pass-occurrences_override_the_type_classification_per_system_3_3.ifc)


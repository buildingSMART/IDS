# Restriction testcases

These testcases are designed to help describe behaviour in edge cases and ambiguities. All valid IDS implementations must demonstrate identical behaviour to these test cases.

## [PASS] An enumeration matches case sensitively 1/3

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>Name</simpleValue>
  </name>
  <value>
    <xs:restriction base="xs:string">
      <xs:enumeration value="Foo"/>
      <xs:enumeration value="Bar"/>
    </xs:restriction>
  </value>
</attribute>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'Foo',$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/restriction/pass-an_enumeration_matches_case_sensitively_1_3.ids) - [Sample IFC: 1](testcases/restriction/pass-an_enumeration_matches_case_sensitively_1_3.ifc)

## [PASS] An enumeration matches case sensitively 2/3

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>Name</simpleValue>
  </name>
  <value>
    <xs:restriction base="xs:string">
      <xs:enumeration value="Foo"/>
      <xs:enumeration value="Bar"/>
    </xs:restriction>
  </value>
</attribute>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'Bar',$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/restriction/pass-an_enumeration_matches_case_sensitively_2_3.ids) - [Sample IFC: 1](testcases/restriction/pass-an_enumeration_matches_case_sensitively_2_3.ifc)

## [FAIL] An enumeration matches case sensitively 3/3

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>Name</simpleValue>
  </name>
  <value>
    <xs:restriction base="xs:string">
      <xs:enumeration value="Foo"/>
      <xs:enumeration value="Bar"/>
    </xs:restriction>
  </value>
</attribute>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'Baz',$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/restriction/fail-an_enumeration_matches_case_sensitively_3_3.ids) - [Sample IFC: 1](testcases/restriction/fail-an_enumeration_matches_case_sensitively_3_3.ifc)

## [PASS] A bound can be inclusive 1/4

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>RefractionIndex</simpleValue>
  </name>
  <value>
    <xs:restriction base="xs:integer">
      <xs:minInclusive value="0" fixed="false"/>
      <xs:maxInclusive value="10" fixed="false"/>
    </xs:restriction>
  </value>
</attribute>
~~~

~~~lua
#1=IFCSURFACESTYLEREFRACTION(0.,$); /* Testcase */
~~~

[Sample IDS](testcases/restriction/pass-a_bound_can_be_inclusive_1_4.ids) - [Sample IFC: 1](testcases/restriction/pass-a_bound_can_be_inclusive_1_4.ifc)

## [PASS] A bound can be inclusive 2/4

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>RefractionIndex</simpleValue>
  </name>
  <value>
    <xs:restriction base="xs:integer">
      <xs:minInclusive value="0" fixed="false"/>
      <xs:maxInclusive value="10" fixed="false"/>
    </xs:restriction>
  </value>
</attribute>
~~~

~~~lua
#1=IFCSURFACESTYLEREFRACTION(5.,$); /* Testcase */
~~~

[Sample IDS](testcases/restriction/pass-a_bound_can_be_inclusive_2_4.ids) - [Sample IFC: 1](testcases/restriction/pass-a_bound_can_be_inclusive_2_4.ifc)

## [PASS] A bound can be inclusive 3/4

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>RefractionIndex</simpleValue>
  </name>
  <value>
    <xs:restriction base="xs:integer">
      <xs:minInclusive value="0" fixed="false"/>
      <xs:maxInclusive value="10" fixed="false"/>
    </xs:restriction>
  </value>
</attribute>
~~~

~~~lua
#1=IFCSURFACESTYLEREFRACTION(10.,$); /* Testcase */
~~~

[Sample IDS](testcases/restriction/pass-a_bound_can_be_inclusive_3_4.ids) - [Sample IFC: 1](testcases/restriction/pass-a_bound_can_be_inclusive_3_4.ifc)

## [FAIL] A bound can be inclusive 4/4

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>RefractionIndex</simpleValue>
  </name>
  <value>
    <xs:restriction base="xs:integer">
      <xs:minInclusive value="0" fixed="false"/>
      <xs:maxInclusive value="10" fixed="false"/>
    </xs:restriction>
  </value>
</attribute>
~~~

~~~lua
#1=IFCSURFACESTYLEREFRACTION(100.,$); /* Testcase */
~~~

[Sample IDS](testcases/restriction/fail-a_bound_can_be_inclusive_4_4.ids) - [Sample IFC: 1](testcases/restriction/fail-a_bound_can_be_inclusive_4_4.ifc)

## [FAIL] A bound can be inclusive 1/3

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>RefractionIndex</simpleValue>
  </name>
  <value>
    <xs:restriction base="xs:integer">
      <xs:minExclusive value="0" fixed="false"/>
      <xs:maxExclusive value="10" fixed="false"/>
    </xs:restriction>
  </value>
</attribute>
~~~

~~~lua
#1=IFCSURFACESTYLEREFRACTION(0.,$); /* Testcase */
~~~

[Sample IDS](testcases/restriction/fail-a_bound_can_be_inclusive_1_3.ids) - [Sample IFC: 1](testcases/restriction/fail-a_bound_can_be_inclusive_1_3.ifc)

## [PASS] A bound can be inclusive 2/3

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>RefractionIndex</simpleValue>
  </name>
  <value>
    <xs:restriction base="xs:integer">
      <xs:minExclusive value="0" fixed="false"/>
      <xs:maxExclusive value="10" fixed="false"/>
    </xs:restriction>
  </value>
</attribute>
~~~

~~~lua
#1=IFCSURFACESTYLEREFRACTION(5.,$); /* Testcase */
~~~

[Sample IDS](testcases/restriction/pass-a_bound_can_be_inclusive_2_3.ids) - [Sample IFC: 1](testcases/restriction/pass-a_bound_can_be_inclusive_2_3.ifc)

## [FAIL] A bound can be inclusive 3/3

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>RefractionIndex</simpleValue>
  </name>
  <value>
    <xs:restriction base="xs:integer">
      <xs:minExclusive value="0" fixed="false"/>
      <xs:maxExclusive value="10" fixed="false"/>
    </xs:restriction>
  </value>
</attribute>
~~~

~~~lua
#1=IFCSURFACESTYLEREFRACTION(10.,$); /* Testcase */
~~~

[Sample IDS](testcases/restriction/fail-a_bound_can_be_inclusive_3_3.ids) - [Sample IFC: 1](testcases/restriction/fail-a_bound_can_be_inclusive_3_3.ifc)

## [PASS] Regex patterns can be used 1/3

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>Name</simpleValue>
  </name>
  <value>
    <xs:restriction base="xs:string">
      <xs:pattern value="[A-Z]{2}[0-9]{2}"/>
    </xs:restriction>
  </value>
</attribute>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'WT01',$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/restriction/pass-regex_patterns_can_be_used_1_3.ids) - [Sample IFC: 1](testcases/restriction/pass-regex_patterns_can_be_used_1_3.ifc)

## [PASS] Regex patterns can be used 2/3

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>Name</simpleValue>
  </name>
  <value>
    <xs:restriction base="xs:string">
      <xs:pattern value="[A-Z]{2}[0-9]{2}"/>
    </xs:restriction>
  </value>
</attribute>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'XY99',$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/restriction/pass-regex_patterns_can_be_used_2_3.ids) - [Sample IFC: 1](testcases/restriction/pass-regex_patterns_can_be_used_2_3.ifc)

## [FAIL] Regex patterns can be used 3/3

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>Name</simpleValue>
  </name>
  <value>
    <xs:restriction base="xs:string">
      <xs:pattern value="[A-Z]{2}[0-9]{2}"/>
    </xs:restriction>
  </value>
</attribute>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'A5',$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/restriction/fail-regex_patterns_can_be_used_3_3.ids) - [Sample IFC: 1](testcases/restriction/fail-regex_patterns_can_be_used_3_3.ifc)

## [PASS] Length checks can be used 1/2

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>Name</simpleValue>
  </name>
  <value>
    <xs:restriction base="xs:string">
      <xs:length value="2" fixed="false"/>
    </xs:restriction>
  </value>
</attribute>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'AB',$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/restriction/pass-length_checks_can_be_used_1_2.ids) - [Sample IFC: 1](testcases/restriction/pass-length_checks_can_be_used_1_2.ifc)

## [FAIL] Length checks can be used 1/2

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>Name</simpleValue>
  </name>
  <value>
    <xs:restriction base="xs:string">
      <xs:length value="2" fixed="false"/>
    </xs:restriction>
  </value>
</attribute>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'ABC',$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/restriction/fail-length_checks_can_be_used_1_2.ids) - [Sample IFC: 1](testcases/restriction/fail-length_checks_can_be_used_1_2.ifc)

## [FAIL] Max and min length checks can be used 1/3

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>Name</simpleValue>
  </name>
  <value>
    <xs:restriction base="xs:string">
      <xs:minLength value="2" fixed="false"/>
      <xs:maxLength value="3" fixed="false"/>
    </xs:restriction>
  </value>
</attribute>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'A',$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/restriction/fail-max_and_min_length_checks_can_be_used_1_3.ids) - [Sample IFC: 1](testcases/restriction/fail-max_and_min_length_checks_can_be_used_1_3.ifc)

## [PASS] Max and min length checks can be used 2/3

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>Name</simpleValue>
  </name>
  <value>
    <xs:restriction base="xs:string">
      <xs:minLength value="2" fixed="false"/>
      <xs:maxLength value="3" fixed="false"/>
    </xs:restriction>
  </value>
</attribute>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'AB',$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/restriction/pass-max_and_min_length_checks_can_be_used_2_3.ids) - [Sample IFC: 1](testcases/restriction/pass-max_and_min_length_checks_can_be_used_2_3.ifc)

## [PASS] Max and min length checks can be used 3/3

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>Name</simpleValue>
  </name>
  <value>
    <xs:restriction base="xs:string">
      <xs:minLength value="2" fixed="false"/>
      <xs:maxLength value="3" fixed="false"/>
    </xs:restriction>
  </value>
</attribute>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'ABC',$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/restriction/pass-max_and_min_length_checks_can_be_used_3_3.ids) - [Sample IFC: 1](testcases/restriction/pass-max_and_min_length_checks_can_be_used_3_3.ifc)

## [FAIL] Max and min length checks can be used 4/3

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>Name</simpleValue>
  </name>
  <value>
    <xs:restriction base="xs:string">
      <xs:minLength value="2" fixed="false"/>
      <xs:maxLength value="3" fixed="false"/>
    </xs:restriction>
  </value>
</attribute>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'ABCD',$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/restriction/fail-max_and_min_length_checks_can_be_used_4_3.ids) - [Sample IFC: 1](testcases/restriction/fail-max_and_min_length_checks_can_be_used_4_3.ifc)


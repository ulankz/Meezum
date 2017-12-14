#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_Object2689449295.h"

// System.String
struct String_t;
// System.Xml.Serialization.XmlAttributeOverrides
struct XmlAttributeOverrides_t3994942922;
// System.Collections.ArrayList
struct ArrayList_t4252133567;
// System.Xml.Serialization.ReflectionHelper
struct ReflectionHelper_t3833447559;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Serialization.XmlReflectionImporter
struct  XmlReflectionImporter_t1815714992  : public Il2CppObject
{
public:
	// System.String System.Xml.Serialization.XmlReflectionImporter::initialDefaultNamespace
	String_t* ___initialDefaultNamespace_0;
	// System.Xml.Serialization.XmlAttributeOverrides System.Xml.Serialization.XmlReflectionImporter::attributeOverrides
	XmlAttributeOverrides_t3994942922 * ___attributeOverrides_1;
	// System.Collections.ArrayList System.Xml.Serialization.XmlReflectionImporter::includedTypes
	ArrayList_t4252133567 * ___includedTypes_2;
	// System.Xml.Serialization.ReflectionHelper System.Xml.Serialization.XmlReflectionImporter::helper
	ReflectionHelper_t3833447559 * ___helper_3;
	// System.Int32 System.Xml.Serialization.XmlReflectionImporter::arrayChoiceCount
	int32_t ___arrayChoiceCount_4;
	// System.Collections.ArrayList System.Xml.Serialization.XmlReflectionImporter::relatedMaps
	ArrayList_t4252133567 * ___relatedMaps_5;
	// System.Boolean System.Xml.Serialization.XmlReflectionImporter::allowPrivateTypes
	bool ___allowPrivateTypes_6;

public:
	inline static int32_t get_offset_of_initialDefaultNamespace_0() { return static_cast<int32_t>(offsetof(XmlReflectionImporter_t1815714992, ___initialDefaultNamespace_0)); }
	inline String_t* get_initialDefaultNamespace_0() const { return ___initialDefaultNamespace_0; }
	inline String_t** get_address_of_initialDefaultNamespace_0() { return &___initialDefaultNamespace_0; }
	inline void set_initialDefaultNamespace_0(String_t* value)
	{
		___initialDefaultNamespace_0 = value;
		Il2CppCodeGenWriteBarrier(&___initialDefaultNamespace_0, value);
	}

	inline static int32_t get_offset_of_attributeOverrides_1() { return static_cast<int32_t>(offsetof(XmlReflectionImporter_t1815714992, ___attributeOverrides_1)); }
	inline XmlAttributeOverrides_t3994942922 * get_attributeOverrides_1() const { return ___attributeOverrides_1; }
	inline XmlAttributeOverrides_t3994942922 ** get_address_of_attributeOverrides_1() { return &___attributeOverrides_1; }
	inline void set_attributeOverrides_1(XmlAttributeOverrides_t3994942922 * value)
	{
		___attributeOverrides_1 = value;
		Il2CppCodeGenWriteBarrier(&___attributeOverrides_1, value);
	}

	inline static int32_t get_offset_of_includedTypes_2() { return static_cast<int32_t>(offsetof(XmlReflectionImporter_t1815714992, ___includedTypes_2)); }
	inline ArrayList_t4252133567 * get_includedTypes_2() const { return ___includedTypes_2; }
	inline ArrayList_t4252133567 ** get_address_of_includedTypes_2() { return &___includedTypes_2; }
	inline void set_includedTypes_2(ArrayList_t4252133567 * value)
	{
		___includedTypes_2 = value;
		Il2CppCodeGenWriteBarrier(&___includedTypes_2, value);
	}

	inline static int32_t get_offset_of_helper_3() { return static_cast<int32_t>(offsetof(XmlReflectionImporter_t1815714992, ___helper_3)); }
	inline ReflectionHelper_t3833447559 * get_helper_3() const { return ___helper_3; }
	inline ReflectionHelper_t3833447559 ** get_address_of_helper_3() { return &___helper_3; }
	inline void set_helper_3(ReflectionHelper_t3833447559 * value)
	{
		___helper_3 = value;
		Il2CppCodeGenWriteBarrier(&___helper_3, value);
	}

	inline static int32_t get_offset_of_arrayChoiceCount_4() { return static_cast<int32_t>(offsetof(XmlReflectionImporter_t1815714992, ___arrayChoiceCount_4)); }
	inline int32_t get_arrayChoiceCount_4() const { return ___arrayChoiceCount_4; }
	inline int32_t* get_address_of_arrayChoiceCount_4() { return &___arrayChoiceCount_4; }
	inline void set_arrayChoiceCount_4(int32_t value)
	{
		___arrayChoiceCount_4 = value;
	}

	inline static int32_t get_offset_of_relatedMaps_5() { return static_cast<int32_t>(offsetof(XmlReflectionImporter_t1815714992, ___relatedMaps_5)); }
	inline ArrayList_t4252133567 * get_relatedMaps_5() const { return ___relatedMaps_5; }
	inline ArrayList_t4252133567 ** get_address_of_relatedMaps_5() { return &___relatedMaps_5; }
	inline void set_relatedMaps_5(ArrayList_t4252133567 * value)
	{
		___relatedMaps_5 = value;
		Il2CppCodeGenWriteBarrier(&___relatedMaps_5, value);
	}

	inline static int32_t get_offset_of_allowPrivateTypes_6() { return static_cast<int32_t>(offsetof(XmlReflectionImporter_t1815714992, ___allowPrivateTypes_6)); }
	inline bool get_allowPrivateTypes_6() const { return ___allowPrivateTypes_6; }
	inline bool* get_address_of_allowPrivateTypes_6() { return &___allowPrivateTypes_6; }
	inline void set_allowPrivateTypes_6(bool value)
	{
		___allowPrivateTypes_6 = value;
	}
};

struct XmlReflectionImporter_t1815714992_StaticFields
{
public:
	// System.String System.Xml.Serialization.XmlReflectionImporter::errSimple
	String_t* ___errSimple_7;
	// System.String System.Xml.Serialization.XmlReflectionImporter::errSimple2
	String_t* ___errSimple2_8;

public:
	inline static int32_t get_offset_of_errSimple_7() { return static_cast<int32_t>(offsetof(XmlReflectionImporter_t1815714992_StaticFields, ___errSimple_7)); }
	inline String_t* get_errSimple_7() const { return ___errSimple_7; }
	inline String_t** get_address_of_errSimple_7() { return &___errSimple_7; }
	inline void set_errSimple_7(String_t* value)
	{
		___errSimple_7 = value;
		Il2CppCodeGenWriteBarrier(&___errSimple_7, value);
	}

	inline static int32_t get_offset_of_errSimple2_8() { return static_cast<int32_t>(offsetof(XmlReflectionImporter_t1815714992_StaticFields, ___errSimple2_8)); }
	inline String_t* get_errSimple2_8() const { return ___errSimple2_8; }
	inline String_t** get_address_of_errSimple2_8() { return &___errSimple2_8; }
	inline void set_errSimple2_8(String_t* value)
	{
		___errSimple2_8 = value;
		Il2CppCodeGenWriteBarrier(&___errSimple2_8, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

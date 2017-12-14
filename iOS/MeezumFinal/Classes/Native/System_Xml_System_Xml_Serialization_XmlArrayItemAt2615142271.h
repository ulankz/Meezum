#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_Attribute542643598.h"
#include "System_Xml_System_Xml_Schema_XmlSchemaForm1143227640.h"

// System.String
struct String_t;
// System.Type
struct Type_t;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Serialization.XmlArrayItemAttribute
struct  XmlArrayItemAttribute_t2615142271  : public Attribute_t542643598
{
public:
	// System.String System.Xml.Serialization.XmlArrayItemAttribute::dataType
	String_t* ___dataType_0;
	// System.String System.Xml.Serialization.XmlArrayItemAttribute::elementName
	String_t* ___elementName_1;
	// System.Xml.Schema.XmlSchemaForm System.Xml.Serialization.XmlArrayItemAttribute::form
	int32_t ___form_2;
	// System.String System.Xml.Serialization.XmlArrayItemAttribute::ns
	String_t* ___ns_3;
	// System.Boolean System.Xml.Serialization.XmlArrayItemAttribute::isNullable
	bool ___isNullable_4;
	// System.Int32 System.Xml.Serialization.XmlArrayItemAttribute::nestingLevel
	int32_t ___nestingLevel_5;
	// System.Type System.Xml.Serialization.XmlArrayItemAttribute::type
	Type_t * ___type_6;

public:
	inline static int32_t get_offset_of_dataType_0() { return static_cast<int32_t>(offsetof(XmlArrayItemAttribute_t2615142271, ___dataType_0)); }
	inline String_t* get_dataType_0() const { return ___dataType_0; }
	inline String_t** get_address_of_dataType_0() { return &___dataType_0; }
	inline void set_dataType_0(String_t* value)
	{
		___dataType_0 = value;
		Il2CppCodeGenWriteBarrier(&___dataType_0, value);
	}

	inline static int32_t get_offset_of_elementName_1() { return static_cast<int32_t>(offsetof(XmlArrayItemAttribute_t2615142271, ___elementName_1)); }
	inline String_t* get_elementName_1() const { return ___elementName_1; }
	inline String_t** get_address_of_elementName_1() { return &___elementName_1; }
	inline void set_elementName_1(String_t* value)
	{
		___elementName_1 = value;
		Il2CppCodeGenWriteBarrier(&___elementName_1, value);
	}

	inline static int32_t get_offset_of_form_2() { return static_cast<int32_t>(offsetof(XmlArrayItemAttribute_t2615142271, ___form_2)); }
	inline int32_t get_form_2() const { return ___form_2; }
	inline int32_t* get_address_of_form_2() { return &___form_2; }
	inline void set_form_2(int32_t value)
	{
		___form_2 = value;
	}

	inline static int32_t get_offset_of_ns_3() { return static_cast<int32_t>(offsetof(XmlArrayItemAttribute_t2615142271, ___ns_3)); }
	inline String_t* get_ns_3() const { return ___ns_3; }
	inline String_t** get_address_of_ns_3() { return &___ns_3; }
	inline void set_ns_3(String_t* value)
	{
		___ns_3 = value;
		Il2CppCodeGenWriteBarrier(&___ns_3, value);
	}

	inline static int32_t get_offset_of_isNullable_4() { return static_cast<int32_t>(offsetof(XmlArrayItemAttribute_t2615142271, ___isNullable_4)); }
	inline bool get_isNullable_4() const { return ___isNullable_4; }
	inline bool* get_address_of_isNullable_4() { return &___isNullable_4; }
	inline void set_isNullable_4(bool value)
	{
		___isNullable_4 = value;
	}

	inline static int32_t get_offset_of_nestingLevel_5() { return static_cast<int32_t>(offsetof(XmlArrayItemAttribute_t2615142271, ___nestingLevel_5)); }
	inline int32_t get_nestingLevel_5() const { return ___nestingLevel_5; }
	inline int32_t* get_address_of_nestingLevel_5() { return &___nestingLevel_5; }
	inline void set_nestingLevel_5(int32_t value)
	{
		___nestingLevel_5 = value;
	}

	inline static int32_t get_offset_of_type_6() { return static_cast<int32_t>(offsetof(XmlArrayItemAttribute_t2615142271, ___type_6)); }
	inline Type_t * get_type_6() const { return ___type_6; }
	inline Type_t ** get_address_of_type_6() { return &___type_6; }
	inline void set_type_6(Type_t * value)
	{
		___type_6 = value;
		Il2CppCodeGenWriteBarrier(&___type_6, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

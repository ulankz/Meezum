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

// System.Xml.Serialization.XmlAttributeAttribute
struct  XmlAttributeAttribute_t850813783  : public Attribute_t542643598
{
public:
	// System.String System.Xml.Serialization.XmlAttributeAttribute::attributeName
	String_t* ___attributeName_0;
	// System.String System.Xml.Serialization.XmlAttributeAttribute::dataType
	String_t* ___dataType_1;
	// System.Type System.Xml.Serialization.XmlAttributeAttribute::type
	Type_t * ___type_2;
	// System.Xml.Schema.XmlSchemaForm System.Xml.Serialization.XmlAttributeAttribute::form
	int32_t ___form_3;
	// System.String System.Xml.Serialization.XmlAttributeAttribute::ns
	String_t* ___ns_4;

public:
	inline static int32_t get_offset_of_attributeName_0() { return static_cast<int32_t>(offsetof(XmlAttributeAttribute_t850813783, ___attributeName_0)); }
	inline String_t* get_attributeName_0() const { return ___attributeName_0; }
	inline String_t** get_address_of_attributeName_0() { return &___attributeName_0; }
	inline void set_attributeName_0(String_t* value)
	{
		___attributeName_0 = value;
		Il2CppCodeGenWriteBarrier(&___attributeName_0, value);
	}

	inline static int32_t get_offset_of_dataType_1() { return static_cast<int32_t>(offsetof(XmlAttributeAttribute_t850813783, ___dataType_1)); }
	inline String_t* get_dataType_1() const { return ___dataType_1; }
	inline String_t** get_address_of_dataType_1() { return &___dataType_1; }
	inline void set_dataType_1(String_t* value)
	{
		___dataType_1 = value;
		Il2CppCodeGenWriteBarrier(&___dataType_1, value);
	}

	inline static int32_t get_offset_of_type_2() { return static_cast<int32_t>(offsetof(XmlAttributeAttribute_t850813783, ___type_2)); }
	inline Type_t * get_type_2() const { return ___type_2; }
	inline Type_t ** get_address_of_type_2() { return &___type_2; }
	inline void set_type_2(Type_t * value)
	{
		___type_2 = value;
		Il2CppCodeGenWriteBarrier(&___type_2, value);
	}

	inline static int32_t get_offset_of_form_3() { return static_cast<int32_t>(offsetof(XmlAttributeAttribute_t850813783, ___form_3)); }
	inline int32_t get_form_3() const { return ___form_3; }
	inline int32_t* get_address_of_form_3() { return &___form_3; }
	inline void set_form_3(int32_t value)
	{
		___form_3 = value;
	}

	inline static int32_t get_offset_of_ns_4() { return static_cast<int32_t>(offsetof(XmlAttributeAttribute_t850813783, ___ns_4)); }
	inline String_t* get_ns_4() const { return ___ns_4; }
	inline String_t** get_address_of_ns_4() { return &___ns_4; }
	inline void set_ns_4(String_t* value)
	{
		___ns_4 = value;
		Il2CppCodeGenWriteBarrier(&___ns_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

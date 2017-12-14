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




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Serialization.XmlArrayAttribute
struct  XmlArrayAttribute_t4163692084  : public Attribute_t542643598
{
public:
	// System.String System.Xml.Serialization.XmlArrayAttribute::elementName
	String_t* ___elementName_0;
	// System.Xml.Schema.XmlSchemaForm System.Xml.Serialization.XmlArrayAttribute::form
	int32_t ___form_1;
	// System.Boolean System.Xml.Serialization.XmlArrayAttribute::isNullable
	bool ___isNullable_2;
	// System.String System.Xml.Serialization.XmlArrayAttribute::ns
	String_t* ___ns_3;
	// System.Int32 System.Xml.Serialization.XmlArrayAttribute::order
	int32_t ___order_4;

public:
	inline static int32_t get_offset_of_elementName_0() { return static_cast<int32_t>(offsetof(XmlArrayAttribute_t4163692084, ___elementName_0)); }
	inline String_t* get_elementName_0() const { return ___elementName_0; }
	inline String_t** get_address_of_elementName_0() { return &___elementName_0; }
	inline void set_elementName_0(String_t* value)
	{
		___elementName_0 = value;
		Il2CppCodeGenWriteBarrier(&___elementName_0, value);
	}

	inline static int32_t get_offset_of_form_1() { return static_cast<int32_t>(offsetof(XmlArrayAttribute_t4163692084, ___form_1)); }
	inline int32_t get_form_1() const { return ___form_1; }
	inline int32_t* get_address_of_form_1() { return &___form_1; }
	inline void set_form_1(int32_t value)
	{
		___form_1 = value;
	}

	inline static int32_t get_offset_of_isNullable_2() { return static_cast<int32_t>(offsetof(XmlArrayAttribute_t4163692084, ___isNullable_2)); }
	inline bool get_isNullable_2() const { return ___isNullable_2; }
	inline bool* get_address_of_isNullable_2() { return &___isNullable_2; }
	inline void set_isNullable_2(bool value)
	{
		___isNullable_2 = value;
	}

	inline static int32_t get_offset_of_ns_3() { return static_cast<int32_t>(offsetof(XmlArrayAttribute_t4163692084, ___ns_3)); }
	inline String_t* get_ns_3() const { return ___ns_3; }
	inline String_t** get_address_of_ns_3() { return &___ns_3; }
	inline void set_ns_3(String_t* value)
	{
		___ns_3 = value;
		Il2CppCodeGenWriteBarrier(&___ns_3, value);
	}

	inline static int32_t get_offset_of_order_4() { return static_cast<int32_t>(offsetof(XmlArrayAttribute_t4163692084, ___order_4)); }
	inline int32_t get_order_4() const { return ___order_4; }
	inline int32_t* get_address_of_order_4() { return &___order_4; }
	inline void set_order_4(int32_t value)
	{
		___order_4 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

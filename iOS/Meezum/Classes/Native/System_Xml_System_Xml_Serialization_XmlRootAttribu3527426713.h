#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_Attribute542643598.h"

// System.String
struct String_t;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Serialization.XmlRootAttribute
struct  XmlRootAttribute_t3527426713  : public Attribute_t542643598
{
public:
	// System.String System.Xml.Serialization.XmlRootAttribute::dataType
	String_t* ___dataType_0;
	// System.String System.Xml.Serialization.XmlRootAttribute::elementName
	String_t* ___elementName_1;
	// System.Boolean System.Xml.Serialization.XmlRootAttribute::isNullable
	bool ___isNullable_2;
	// System.String System.Xml.Serialization.XmlRootAttribute::ns
	String_t* ___ns_3;

public:
	inline static int32_t get_offset_of_dataType_0() { return static_cast<int32_t>(offsetof(XmlRootAttribute_t3527426713, ___dataType_0)); }
	inline String_t* get_dataType_0() const { return ___dataType_0; }
	inline String_t** get_address_of_dataType_0() { return &___dataType_0; }
	inline void set_dataType_0(String_t* value)
	{
		___dataType_0 = value;
		Il2CppCodeGenWriteBarrier(&___dataType_0, value);
	}

	inline static int32_t get_offset_of_elementName_1() { return static_cast<int32_t>(offsetof(XmlRootAttribute_t3527426713, ___elementName_1)); }
	inline String_t* get_elementName_1() const { return ___elementName_1; }
	inline String_t** get_address_of_elementName_1() { return &___elementName_1; }
	inline void set_elementName_1(String_t* value)
	{
		___elementName_1 = value;
		Il2CppCodeGenWriteBarrier(&___elementName_1, value);
	}

	inline static int32_t get_offset_of_isNullable_2() { return static_cast<int32_t>(offsetof(XmlRootAttribute_t3527426713, ___isNullable_2)); }
	inline bool get_isNullable_2() const { return ___isNullable_2; }
	inline bool* get_address_of_isNullable_2() { return &___isNullable_2; }
	inline void set_isNullable_2(bool value)
	{
		___isNullable_2 = value;
	}

	inline static int32_t get_offset_of_ns_3() { return static_cast<int32_t>(offsetof(XmlRootAttribute_t3527426713, ___ns_3)); }
	inline String_t* get_ns_3() const { return ___ns_3; }
	inline String_t** get_address_of_ns_3() { return &___ns_3; }
	inline void set_ns_3(String_t* value)
	{
		___ns_3 = value;
		Il2CppCodeGenWriteBarrier(&___ns_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

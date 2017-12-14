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

// System.Xml.Serialization.XmlTypeAttribute
struct  XmlTypeAttribute_t1804457051  : public Attribute_t542643598
{
public:
	// System.Boolean System.Xml.Serialization.XmlTypeAttribute::includeInSchema
	bool ___includeInSchema_0;
	// System.String System.Xml.Serialization.XmlTypeAttribute::ns
	String_t* ___ns_1;
	// System.String System.Xml.Serialization.XmlTypeAttribute::typeName
	String_t* ___typeName_2;

public:
	inline static int32_t get_offset_of_includeInSchema_0() { return static_cast<int32_t>(offsetof(XmlTypeAttribute_t1804457051, ___includeInSchema_0)); }
	inline bool get_includeInSchema_0() const { return ___includeInSchema_0; }
	inline bool* get_address_of_includeInSchema_0() { return &___includeInSchema_0; }
	inline void set_includeInSchema_0(bool value)
	{
		___includeInSchema_0 = value;
	}

	inline static int32_t get_offset_of_ns_1() { return static_cast<int32_t>(offsetof(XmlTypeAttribute_t1804457051, ___ns_1)); }
	inline String_t* get_ns_1() const { return ___ns_1; }
	inline String_t** get_address_of_ns_1() { return &___ns_1; }
	inline void set_ns_1(String_t* value)
	{
		___ns_1 = value;
		Il2CppCodeGenWriteBarrier(&___ns_1, value);
	}

	inline static int32_t get_offset_of_typeName_2() { return static_cast<int32_t>(offsetof(XmlTypeAttribute_t1804457051, ___typeName_2)); }
	inline String_t* get_typeName_2() const { return ___typeName_2; }
	inline String_t** get_address_of_typeName_2() { return &___typeName_2; }
	inline void set_typeName_2(String_t* value)
	{
		___typeName_2 = value;
		Il2CppCodeGenWriteBarrier(&___typeName_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

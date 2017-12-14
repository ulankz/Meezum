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
// System.Type
struct Type_t;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Serialization.XmlTextAttribute
struct  XmlTextAttribute_t3321178844  : public Attribute_t542643598
{
public:
	// System.String System.Xml.Serialization.XmlTextAttribute::dataType
	String_t* ___dataType_0;
	// System.Type System.Xml.Serialization.XmlTextAttribute::type
	Type_t * ___type_1;

public:
	inline static int32_t get_offset_of_dataType_0() { return static_cast<int32_t>(offsetof(XmlTextAttribute_t3321178844, ___dataType_0)); }
	inline String_t* get_dataType_0() const { return ___dataType_0; }
	inline String_t** get_address_of_dataType_0() { return &___dataType_0; }
	inline void set_dataType_0(String_t* value)
	{
		___dataType_0 = value;
		Il2CppCodeGenWriteBarrier(&___dataType_0, value);
	}

	inline static int32_t get_offset_of_type_1() { return static_cast<int32_t>(offsetof(XmlTextAttribute_t3321178844, ___type_1)); }
	inline Type_t * get_type_1() const { return ___type_1; }
	inline Type_t ** get_address_of_type_1() { return &___type_1; }
	inline void set_type_1(Type_t * value)
	{
		___type_1 = value;
		Il2CppCodeGenWriteBarrier(&___type_1, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

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

// System.Xml.Serialization.XmlAnyElementAttribute
struct  XmlAnyElementAttribute_t2502375235  : public Attribute_t542643598
{
public:
	// System.String System.Xml.Serialization.XmlAnyElementAttribute::elementName
	String_t* ___elementName_0;
	// System.String System.Xml.Serialization.XmlAnyElementAttribute::ns
	String_t* ___ns_1;

public:
	inline static int32_t get_offset_of_elementName_0() { return static_cast<int32_t>(offsetof(XmlAnyElementAttribute_t2502375235, ___elementName_0)); }
	inline String_t* get_elementName_0() const { return ___elementName_0; }
	inline String_t** get_address_of_elementName_0() { return &___elementName_0; }
	inline void set_elementName_0(String_t* value)
	{
		___elementName_0 = value;
		Il2CppCodeGenWriteBarrier(&___elementName_0, value);
	}

	inline static int32_t get_offset_of_ns_1() { return static_cast<int32_t>(offsetof(XmlAnyElementAttribute_t2502375235, ___ns_1)); }
	inline String_t* get_ns_1() const { return ___ns_1; }
	inline String_t** get_address_of_ns_1() { return &___ns_1; }
	inline void set_ns_1(String_t* value)
	{
		___ns_1 = value;
		Il2CppCodeGenWriteBarrier(&___ns_1, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

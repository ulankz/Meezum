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
// System.Type
struct Type_t;
// System.Xml.Serialization.XmlAttributes
struct XmlAttributes_t1176289510;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Serialization.XmlReflectionMember
struct  XmlReflectionMember_t3763194608  : public Il2CppObject
{
public:
	// System.Boolean System.Xml.Serialization.XmlReflectionMember::isReturnValue
	bool ___isReturnValue_0;
	// System.String System.Xml.Serialization.XmlReflectionMember::memberName
	String_t* ___memberName_1;
	// System.Type System.Xml.Serialization.XmlReflectionMember::memberType
	Type_t * ___memberType_2;
	// System.Xml.Serialization.XmlAttributes System.Xml.Serialization.XmlReflectionMember::xmlAttributes
	XmlAttributes_t1176289510 * ___xmlAttributes_3;
	// System.Type System.Xml.Serialization.XmlReflectionMember::declaringType
	Type_t * ___declaringType_4;

public:
	inline static int32_t get_offset_of_isReturnValue_0() { return static_cast<int32_t>(offsetof(XmlReflectionMember_t3763194608, ___isReturnValue_0)); }
	inline bool get_isReturnValue_0() const { return ___isReturnValue_0; }
	inline bool* get_address_of_isReturnValue_0() { return &___isReturnValue_0; }
	inline void set_isReturnValue_0(bool value)
	{
		___isReturnValue_0 = value;
	}

	inline static int32_t get_offset_of_memberName_1() { return static_cast<int32_t>(offsetof(XmlReflectionMember_t3763194608, ___memberName_1)); }
	inline String_t* get_memberName_1() const { return ___memberName_1; }
	inline String_t** get_address_of_memberName_1() { return &___memberName_1; }
	inline void set_memberName_1(String_t* value)
	{
		___memberName_1 = value;
		Il2CppCodeGenWriteBarrier(&___memberName_1, value);
	}

	inline static int32_t get_offset_of_memberType_2() { return static_cast<int32_t>(offsetof(XmlReflectionMember_t3763194608, ___memberType_2)); }
	inline Type_t * get_memberType_2() const { return ___memberType_2; }
	inline Type_t ** get_address_of_memberType_2() { return &___memberType_2; }
	inline void set_memberType_2(Type_t * value)
	{
		___memberType_2 = value;
		Il2CppCodeGenWriteBarrier(&___memberType_2, value);
	}

	inline static int32_t get_offset_of_xmlAttributes_3() { return static_cast<int32_t>(offsetof(XmlReflectionMember_t3763194608, ___xmlAttributes_3)); }
	inline XmlAttributes_t1176289510 * get_xmlAttributes_3() const { return ___xmlAttributes_3; }
	inline XmlAttributes_t1176289510 ** get_address_of_xmlAttributes_3() { return &___xmlAttributes_3; }
	inline void set_xmlAttributes_3(XmlAttributes_t1176289510 * value)
	{
		___xmlAttributes_3 = value;
		Il2CppCodeGenWriteBarrier(&___xmlAttributes_3, value);
	}

	inline static int32_t get_offset_of_declaringType_4() { return static_cast<int32_t>(offsetof(XmlReflectionMember_t3763194608, ___declaringType_4)); }
	inline Type_t * get_declaringType_4() const { return ___declaringType_4; }
	inline Type_t ** get_address_of_declaringType_4() { return &___declaringType_4; }
	inline void set_declaringType_4(Type_t * value)
	{
		___declaringType_4 = value;
		Il2CppCodeGenWriteBarrier(&___declaringType_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

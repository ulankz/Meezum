#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_Object2689449295.h"

// System.Type
struct Type_t;
// System.String
struct String_t;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Serialization.TypeMember
struct  TypeMember_t1615994940  : public Il2CppObject
{
public:
	// System.Type System.Xml.Serialization.TypeMember::type
	Type_t * ___type_0;
	// System.String System.Xml.Serialization.TypeMember::member
	String_t* ___member_1;

public:
	inline static int32_t get_offset_of_type_0() { return static_cast<int32_t>(offsetof(TypeMember_t1615994940, ___type_0)); }
	inline Type_t * get_type_0() const { return ___type_0; }
	inline Type_t ** get_address_of_type_0() { return &___type_0; }
	inline void set_type_0(Type_t * value)
	{
		___type_0 = value;
		Il2CppCodeGenWriteBarrier(&___type_0, value);
	}

	inline static int32_t get_offset_of_member_1() { return static_cast<int32_t>(offsetof(TypeMember_t1615994940, ___member_1)); }
	inline String_t* get_member_1() const { return ___member_1; }
	inline String_t** get_address_of_member_1() { return &___member_1; }
	inline void set_member_1(String_t* value)
	{
		___member_1 = value;
		Il2CppCodeGenWriteBarrier(&___member_1, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

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




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Serialization.EnumMap/EnumMapMember
struct  EnumMapMember_t3814867081  : public Il2CppObject
{
public:
	// System.String System.Xml.Serialization.EnumMap/EnumMapMember::_xmlName
	String_t* ____xmlName_0;
	// System.String System.Xml.Serialization.EnumMap/EnumMapMember::_enumName
	String_t* ____enumName_1;
	// System.Int64 System.Xml.Serialization.EnumMap/EnumMapMember::_value
	int64_t ____value_2;

public:
	inline static int32_t get_offset_of__xmlName_0() { return static_cast<int32_t>(offsetof(EnumMapMember_t3814867081, ____xmlName_0)); }
	inline String_t* get__xmlName_0() const { return ____xmlName_0; }
	inline String_t** get_address_of__xmlName_0() { return &____xmlName_0; }
	inline void set__xmlName_0(String_t* value)
	{
		____xmlName_0 = value;
		Il2CppCodeGenWriteBarrier(&____xmlName_0, value);
	}

	inline static int32_t get_offset_of__enumName_1() { return static_cast<int32_t>(offsetof(EnumMapMember_t3814867081, ____enumName_1)); }
	inline String_t* get__enumName_1() const { return ____enumName_1; }
	inline String_t** get_address_of__enumName_1() { return &____enumName_1; }
	inline void set__enumName_1(String_t* value)
	{
		____enumName_1 = value;
		Il2CppCodeGenWriteBarrier(&____enumName_1, value);
	}

	inline static int32_t get_offset_of__value_2() { return static_cast<int32_t>(offsetof(EnumMapMember_t3814867081, ____value_2)); }
	inline int64_t get__value_2() const { return ____value_2; }
	inline int64_t* get_address_of__value_2() { return &____value_2; }
	inline void set__value_2(int64_t value)
	{
		____value_2 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

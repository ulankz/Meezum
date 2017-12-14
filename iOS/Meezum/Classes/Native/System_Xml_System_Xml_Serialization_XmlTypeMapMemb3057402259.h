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
// System.Xml.Serialization.TypeData
struct TypeData_t3979356678;
// System.Reflection.MemberInfo
struct MemberInfo_t;
// System.Object
struct Il2CppObject;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Serialization.XmlTypeMapMember
struct  XmlTypeMapMember_t3057402259  : public Il2CppObject
{
public:
	// System.String System.Xml.Serialization.XmlTypeMapMember::_name
	String_t* ____name_0;
	// System.Int32 System.Xml.Serialization.XmlTypeMapMember::_index
	int32_t ____index_1;
	// System.Int32 System.Xml.Serialization.XmlTypeMapMember::_globalIndex
	int32_t ____globalIndex_2;
	// System.Xml.Serialization.TypeData System.Xml.Serialization.XmlTypeMapMember::_typeData
	TypeData_t3979356678 * ____typeData_3;
	// System.Reflection.MemberInfo System.Xml.Serialization.XmlTypeMapMember::_member
	MemberInfo_t * ____member_4;
	// System.Reflection.MemberInfo System.Xml.Serialization.XmlTypeMapMember::_specifiedMember
	MemberInfo_t * ____specifiedMember_5;
	// System.Object System.Xml.Serialization.XmlTypeMapMember::_defaultValue
	Il2CppObject * ____defaultValue_6;
	// System.Int32 System.Xml.Serialization.XmlTypeMapMember::_flags
	int32_t ____flags_7;

public:
	inline static int32_t get_offset_of__name_0() { return static_cast<int32_t>(offsetof(XmlTypeMapMember_t3057402259, ____name_0)); }
	inline String_t* get__name_0() const { return ____name_0; }
	inline String_t** get_address_of__name_0() { return &____name_0; }
	inline void set__name_0(String_t* value)
	{
		____name_0 = value;
		Il2CppCodeGenWriteBarrier(&____name_0, value);
	}

	inline static int32_t get_offset_of__index_1() { return static_cast<int32_t>(offsetof(XmlTypeMapMember_t3057402259, ____index_1)); }
	inline int32_t get__index_1() const { return ____index_1; }
	inline int32_t* get_address_of__index_1() { return &____index_1; }
	inline void set__index_1(int32_t value)
	{
		____index_1 = value;
	}

	inline static int32_t get_offset_of__globalIndex_2() { return static_cast<int32_t>(offsetof(XmlTypeMapMember_t3057402259, ____globalIndex_2)); }
	inline int32_t get__globalIndex_2() const { return ____globalIndex_2; }
	inline int32_t* get_address_of__globalIndex_2() { return &____globalIndex_2; }
	inline void set__globalIndex_2(int32_t value)
	{
		____globalIndex_2 = value;
	}

	inline static int32_t get_offset_of__typeData_3() { return static_cast<int32_t>(offsetof(XmlTypeMapMember_t3057402259, ____typeData_3)); }
	inline TypeData_t3979356678 * get__typeData_3() const { return ____typeData_3; }
	inline TypeData_t3979356678 ** get_address_of__typeData_3() { return &____typeData_3; }
	inline void set__typeData_3(TypeData_t3979356678 * value)
	{
		____typeData_3 = value;
		Il2CppCodeGenWriteBarrier(&____typeData_3, value);
	}

	inline static int32_t get_offset_of__member_4() { return static_cast<int32_t>(offsetof(XmlTypeMapMember_t3057402259, ____member_4)); }
	inline MemberInfo_t * get__member_4() const { return ____member_4; }
	inline MemberInfo_t ** get_address_of__member_4() { return &____member_4; }
	inline void set__member_4(MemberInfo_t * value)
	{
		____member_4 = value;
		Il2CppCodeGenWriteBarrier(&____member_4, value);
	}

	inline static int32_t get_offset_of__specifiedMember_5() { return static_cast<int32_t>(offsetof(XmlTypeMapMember_t3057402259, ____specifiedMember_5)); }
	inline MemberInfo_t * get__specifiedMember_5() const { return ____specifiedMember_5; }
	inline MemberInfo_t ** get_address_of__specifiedMember_5() { return &____specifiedMember_5; }
	inline void set__specifiedMember_5(MemberInfo_t * value)
	{
		____specifiedMember_5 = value;
		Il2CppCodeGenWriteBarrier(&____specifiedMember_5, value);
	}

	inline static int32_t get_offset_of__defaultValue_6() { return static_cast<int32_t>(offsetof(XmlTypeMapMember_t3057402259, ____defaultValue_6)); }
	inline Il2CppObject * get__defaultValue_6() const { return ____defaultValue_6; }
	inline Il2CppObject ** get_address_of__defaultValue_6() { return &____defaultValue_6; }
	inline void set__defaultValue_6(Il2CppObject * value)
	{
		____defaultValue_6 = value;
		Il2CppCodeGenWriteBarrier(&____defaultValue_6, value);
	}

	inline static int32_t get_offset_of__flags_7() { return static_cast<int32_t>(offsetof(XmlTypeMapMember_t3057402259, ____flags_7)); }
	inline int32_t get__flags_7() const { return ____flags_7; }
	inline int32_t* get_address_of__flags_7() { return &____flags_7; }
	inline void set__flags_7(int32_t value)
	{
		____flags_7 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

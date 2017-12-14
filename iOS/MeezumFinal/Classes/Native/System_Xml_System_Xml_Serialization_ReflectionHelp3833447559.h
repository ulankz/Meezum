#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_Object2689449295.h"

// System.Collections.Hashtable
struct Hashtable_t909839986;
// System.Reflection.ParameterModifier[]
struct ParameterModifierU5BU5D_t963192633;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Serialization.ReflectionHelper
struct  ReflectionHelper_t3833447559  : public Il2CppObject
{
public:
	// System.Collections.Hashtable System.Xml.Serialization.ReflectionHelper::_clrTypes
	Hashtable_t909839986 * ____clrTypes_0;
	// System.Collections.Hashtable System.Xml.Serialization.ReflectionHelper::_schemaTypes
	Hashtable_t909839986 * ____schemaTypes_1;

public:
	inline static int32_t get_offset_of__clrTypes_0() { return static_cast<int32_t>(offsetof(ReflectionHelper_t3833447559, ____clrTypes_0)); }
	inline Hashtable_t909839986 * get__clrTypes_0() const { return ____clrTypes_0; }
	inline Hashtable_t909839986 ** get_address_of__clrTypes_0() { return &____clrTypes_0; }
	inline void set__clrTypes_0(Hashtable_t909839986 * value)
	{
		____clrTypes_0 = value;
		Il2CppCodeGenWriteBarrier(&____clrTypes_0, value);
	}

	inline static int32_t get_offset_of__schemaTypes_1() { return static_cast<int32_t>(offsetof(ReflectionHelper_t3833447559, ____schemaTypes_1)); }
	inline Hashtable_t909839986 * get__schemaTypes_1() const { return ____schemaTypes_1; }
	inline Hashtable_t909839986 ** get_address_of__schemaTypes_1() { return &____schemaTypes_1; }
	inline void set__schemaTypes_1(Hashtable_t909839986 * value)
	{
		____schemaTypes_1 = value;
		Il2CppCodeGenWriteBarrier(&____schemaTypes_1, value);
	}
};

struct ReflectionHelper_t3833447559_StaticFields
{
public:
	// System.Reflection.ParameterModifier[] System.Xml.Serialization.ReflectionHelper::empty_modifiers
	ParameterModifierU5BU5D_t963192633* ___empty_modifiers_2;

public:
	inline static int32_t get_offset_of_empty_modifiers_2() { return static_cast<int32_t>(offsetof(ReflectionHelper_t3833447559_StaticFields, ___empty_modifiers_2)); }
	inline ParameterModifierU5BU5D_t963192633* get_empty_modifiers_2() const { return ___empty_modifiers_2; }
	inline ParameterModifierU5BU5D_t963192633** get_address_of_empty_modifiers_2() { return &___empty_modifiers_2; }
	inline void set_empty_modifiers_2(ParameterModifierU5BU5D_t963192633* value)
	{
		___empty_modifiers_2 = value;
		Il2CppCodeGenWriteBarrier(&___empty_modifiers_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

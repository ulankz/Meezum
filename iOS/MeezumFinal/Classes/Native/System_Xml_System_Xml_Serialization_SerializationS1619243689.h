#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_Object2689449295.h"

// System.Type[]
struct TypeU5BU5D_t1664964607;
// System.String
struct String_t;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Serialization.SerializationSource
struct  SerializationSource_t1619243689  : public Il2CppObject
{
public:
	// System.Type[] System.Xml.Serialization.SerializationSource::includedTypes
	TypeU5BU5D_t1664964607* ___includedTypes_0;
	// System.String System.Xml.Serialization.SerializationSource::namspace
	String_t* ___namspace_1;
	// System.Boolean System.Xml.Serialization.SerializationSource::canBeGenerated
	bool ___canBeGenerated_2;

public:
	inline static int32_t get_offset_of_includedTypes_0() { return static_cast<int32_t>(offsetof(SerializationSource_t1619243689, ___includedTypes_0)); }
	inline TypeU5BU5D_t1664964607* get_includedTypes_0() const { return ___includedTypes_0; }
	inline TypeU5BU5D_t1664964607** get_address_of_includedTypes_0() { return &___includedTypes_0; }
	inline void set_includedTypes_0(TypeU5BU5D_t1664964607* value)
	{
		___includedTypes_0 = value;
		Il2CppCodeGenWriteBarrier(&___includedTypes_0, value);
	}

	inline static int32_t get_offset_of_namspace_1() { return static_cast<int32_t>(offsetof(SerializationSource_t1619243689, ___namspace_1)); }
	inline String_t* get_namspace_1() const { return ___namspace_1; }
	inline String_t** get_address_of_namspace_1() { return &___namspace_1; }
	inline void set_namspace_1(String_t* value)
	{
		___namspace_1 = value;
		Il2CppCodeGenWriteBarrier(&___namspace_1, value);
	}

	inline static int32_t get_offset_of_canBeGenerated_2() { return static_cast<int32_t>(offsetof(SerializationSource_t1619243689, ___canBeGenerated_2)); }
	inline bool get_canBeGenerated_2() const { return ___canBeGenerated_2; }
	inline bool* get_address_of_canBeGenerated_2() { return &___canBeGenerated_2; }
	inline void set_canBeGenerated_2(bool value)
	{
		___canBeGenerated_2 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

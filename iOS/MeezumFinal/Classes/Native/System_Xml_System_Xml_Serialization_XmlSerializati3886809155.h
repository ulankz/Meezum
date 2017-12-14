#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_Object2689449295.h"

// System.Xml.Serialization.XmlSerializationCollectionFixupCallback
struct XmlSerializationCollectionFixupCallback_t3113026122;
// System.Object
struct Il2CppObject;
// System.String
struct String_t;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Serialization.XmlSerializationReader/CollectionFixup
struct  CollectionFixup_t3886809155  : public Il2CppObject
{
public:
	// System.Xml.Serialization.XmlSerializationCollectionFixupCallback System.Xml.Serialization.XmlSerializationReader/CollectionFixup::callback
	XmlSerializationCollectionFixupCallback_t3113026122 * ___callback_0;
	// System.Object System.Xml.Serialization.XmlSerializationReader/CollectionFixup::collection
	Il2CppObject * ___collection_1;
	// System.Object System.Xml.Serialization.XmlSerializationReader/CollectionFixup::collectionItems
	Il2CppObject * ___collectionItems_2;
	// System.String System.Xml.Serialization.XmlSerializationReader/CollectionFixup::id
	String_t* ___id_3;

public:
	inline static int32_t get_offset_of_callback_0() { return static_cast<int32_t>(offsetof(CollectionFixup_t3886809155, ___callback_0)); }
	inline XmlSerializationCollectionFixupCallback_t3113026122 * get_callback_0() const { return ___callback_0; }
	inline XmlSerializationCollectionFixupCallback_t3113026122 ** get_address_of_callback_0() { return &___callback_0; }
	inline void set_callback_0(XmlSerializationCollectionFixupCallback_t3113026122 * value)
	{
		___callback_0 = value;
		Il2CppCodeGenWriteBarrier(&___callback_0, value);
	}

	inline static int32_t get_offset_of_collection_1() { return static_cast<int32_t>(offsetof(CollectionFixup_t3886809155, ___collection_1)); }
	inline Il2CppObject * get_collection_1() const { return ___collection_1; }
	inline Il2CppObject ** get_address_of_collection_1() { return &___collection_1; }
	inline void set_collection_1(Il2CppObject * value)
	{
		___collection_1 = value;
		Il2CppCodeGenWriteBarrier(&___collection_1, value);
	}

	inline static int32_t get_offset_of_collectionItems_2() { return static_cast<int32_t>(offsetof(CollectionFixup_t3886809155, ___collectionItems_2)); }
	inline Il2CppObject * get_collectionItems_2() const { return ___collectionItems_2; }
	inline Il2CppObject ** get_address_of_collectionItems_2() { return &___collectionItems_2; }
	inline void set_collectionItems_2(Il2CppObject * value)
	{
		___collectionItems_2 = value;
		Il2CppCodeGenWriteBarrier(&___collectionItems_2, value);
	}

	inline static int32_t get_offset_of_id_3() { return static_cast<int32_t>(offsetof(CollectionFixup_t3886809155, ___id_3)); }
	inline String_t* get_id_3() const { return ___id_3; }
	inline String_t** get_address_of_id_3() { return &___id_3; }
	inline void set_id_3(String_t* value)
	{
		___id_3 = value;
		Il2CppCodeGenWriteBarrier(&___id_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

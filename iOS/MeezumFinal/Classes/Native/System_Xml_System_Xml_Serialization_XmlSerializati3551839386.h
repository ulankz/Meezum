#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "System_Xml_System_Xml_Serialization_XmlSerializatio148621035.h"

// System.Xml.XmlDocument
struct XmlDocument_t3649534162;
// System.Xml.XmlReader
struct XmlReader_t3675626668;
// System.Collections.ArrayList
struct ArrayList_t4252133567;
// System.Collections.Hashtable
struct Hashtable_t909839986;
// System.Xml.Serialization.XmlSerializer
struct XmlSerializer_t1255294979;
// System.String
struct String_t;
// System.Xml.XmlQualifiedName
struct XmlQualifiedName_t1944712516;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Serialization.XmlSerializationReader
struct  XmlSerializationReader_t3551839386  : public XmlSerializationGeneratedCode_t148621035
{
public:
	// System.Xml.XmlDocument System.Xml.Serialization.XmlSerializationReader::document
	XmlDocument_t3649534162 * ___document_0;
	// System.Xml.XmlReader System.Xml.Serialization.XmlSerializationReader::reader
	XmlReader_t3675626668 * ___reader_1;
	// System.Collections.ArrayList System.Xml.Serialization.XmlSerializationReader::fixups
	ArrayList_t4252133567 * ___fixups_2;
	// System.Collections.Hashtable System.Xml.Serialization.XmlSerializationReader::collFixups
	Hashtable_t909839986 * ___collFixups_3;
	// System.Collections.ArrayList System.Xml.Serialization.XmlSerializationReader::collItemFixups
	ArrayList_t4252133567 * ___collItemFixups_4;
	// System.Collections.Hashtable System.Xml.Serialization.XmlSerializationReader::typesCallbacks
	Hashtable_t909839986 * ___typesCallbacks_5;
	// System.Collections.ArrayList System.Xml.Serialization.XmlSerializationReader::noIDTargets
	ArrayList_t4252133567 * ___noIDTargets_6;
	// System.Collections.Hashtable System.Xml.Serialization.XmlSerializationReader::targets
	Hashtable_t909839986 * ___targets_7;
	// System.Collections.Hashtable System.Xml.Serialization.XmlSerializationReader::delayedListFixups
	Hashtable_t909839986 * ___delayedListFixups_8;
	// System.Xml.Serialization.XmlSerializer System.Xml.Serialization.XmlSerializationReader::eventSource
	XmlSerializer_t1255294979 * ___eventSource_9;
	// System.Int32 System.Xml.Serialization.XmlSerializationReader::delayedFixupId
	int32_t ___delayedFixupId_10;
	// System.Collections.Hashtable System.Xml.Serialization.XmlSerializationReader::referencedObjects
	Hashtable_t909839986 * ___referencedObjects_11;
	// System.Int32 System.Xml.Serialization.XmlSerializationReader::readCount
	int32_t ___readCount_12;
	// System.Int32 System.Xml.Serialization.XmlSerializationReader::whileIterationCount
	int32_t ___whileIterationCount_13;
	// System.String System.Xml.Serialization.XmlSerializationReader::w3SchemaNS
	String_t* ___w3SchemaNS_14;
	// System.String System.Xml.Serialization.XmlSerializationReader::w3InstanceNS
	String_t* ___w3InstanceNS_15;
	// System.String System.Xml.Serialization.XmlSerializationReader::w3InstanceNS2000
	String_t* ___w3InstanceNS2000_16;
	// System.String System.Xml.Serialization.XmlSerializationReader::w3InstanceNS1999
	String_t* ___w3InstanceNS1999_17;
	// System.String System.Xml.Serialization.XmlSerializationReader::soapNS
	String_t* ___soapNS_18;
	// System.String System.Xml.Serialization.XmlSerializationReader::wsdlNS
	String_t* ___wsdlNS_19;
	// System.String System.Xml.Serialization.XmlSerializationReader::nullX
	String_t* ___nullX_20;
	// System.String System.Xml.Serialization.XmlSerializationReader::nil
	String_t* ___nil_21;
	// System.String System.Xml.Serialization.XmlSerializationReader::typeX
	String_t* ___typeX_22;
	// System.String System.Xml.Serialization.XmlSerializationReader::arrayType
	String_t* ___arrayType_23;
	// System.Xml.XmlQualifiedName System.Xml.Serialization.XmlSerializationReader::arrayQName
	XmlQualifiedName_t1944712516 * ___arrayQName_24;

public:
	inline static int32_t get_offset_of_document_0() { return static_cast<int32_t>(offsetof(XmlSerializationReader_t3551839386, ___document_0)); }
	inline XmlDocument_t3649534162 * get_document_0() const { return ___document_0; }
	inline XmlDocument_t3649534162 ** get_address_of_document_0() { return &___document_0; }
	inline void set_document_0(XmlDocument_t3649534162 * value)
	{
		___document_0 = value;
		Il2CppCodeGenWriteBarrier(&___document_0, value);
	}

	inline static int32_t get_offset_of_reader_1() { return static_cast<int32_t>(offsetof(XmlSerializationReader_t3551839386, ___reader_1)); }
	inline XmlReader_t3675626668 * get_reader_1() const { return ___reader_1; }
	inline XmlReader_t3675626668 ** get_address_of_reader_1() { return &___reader_1; }
	inline void set_reader_1(XmlReader_t3675626668 * value)
	{
		___reader_1 = value;
		Il2CppCodeGenWriteBarrier(&___reader_1, value);
	}

	inline static int32_t get_offset_of_fixups_2() { return static_cast<int32_t>(offsetof(XmlSerializationReader_t3551839386, ___fixups_2)); }
	inline ArrayList_t4252133567 * get_fixups_2() const { return ___fixups_2; }
	inline ArrayList_t4252133567 ** get_address_of_fixups_2() { return &___fixups_2; }
	inline void set_fixups_2(ArrayList_t4252133567 * value)
	{
		___fixups_2 = value;
		Il2CppCodeGenWriteBarrier(&___fixups_2, value);
	}

	inline static int32_t get_offset_of_collFixups_3() { return static_cast<int32_t>(offsetof(XmlSerializationReader_t3551839386, ___collFixups_3)); }
	inline Hashtable_t909839986 * get_collFixups_3() const { return ___collFixups_3; }
	inline Hashtable_t909839986 ** get_address_of_collFixups_3() { return &___collFixups_3; }
	inline void set_collFixups_3(Hashtable_t909839986 * value)
	{
		___collFixups_3 = value;
		Il2CppCodeGenWriteBarrier(&___collFixups_3, value);
	}

	inline static int32_t get_offset_of_collItemFixups_4() { return static_cast<int32_t>(offsetof(XmlSerializationReader_t3551839386, ___collItemFixups_4)); }
	inline ArrayList_t4252133567 * get_collItemFixups_4() const { return ___collItemFixups_4; }
	inline ArrayList_t4252133567 ** get_address_of_collItemFixups_4() { return &___collItemFixups_4; }
	inline void set_collItemFixups_4(ArrayList_t4252133567 * value)
	{
		___collItemFixups_4 = value;
		Il2CppCodeGenWriteBarrier(&___collItemFixups_4, value);
	}

	inline static int32_t get_offset_of_typesCallbacks_5() { return static_cast<int32_t>(offsetof(XmlSerializationReader_t3551839386, ___typesCallbacks_5)); }
	inline Hashtable_t909839986 * get_typesCallbacks_5() const { return ___typesCallbacks_5; }
	inline Hashtable_t909839986 ** get_address_of_typesCallbacks_5() { return &___typesCallbacks_5; }
	inline void set_typesCallbacks_5(Hashtable_t909839986 * value)
	{
		___typesCallbacks_5 = value;
		Il2CppCodeGenWriteBarrier(&___typesCallbacks_5, value);
	}

	inline static int32_t get_offset_of_noIDTargets_6() { return static_cast<int32_t>(offsetof(XmlSerializationReader_t3551839386, ___noIDTargets_6)); }
	inline ArrayList_t4252133567 * get_noIDTargets_6() const { return ___noIDTargets_6; }
	inline ArrayList_t4252133567 ** get_address_of_noIDTargets_6() { return &___noIDTargets_6; }
	inline void set_noIDTargets_6(ArrayList_t4252133567 * value)
	{
		___noIDTargets_6 = value;
		Il2CppCodeGenWriteBarrier(&___noIDTargets_6, value);
	}

	inline static int32_t get_offset_of_targets_7() { return static_cast<int32_t>(offsetof(XmlSerializationReader_t3551839386, ___targets_7)); }
	inline Hashtable_t909839986 * get_targets_7() const { return ___targets_7; }
	inline Hashtable_t909839986 ** get_address_of_targets_7() { return &___targets_7; }
	inline void set_targets_7(Hashtable_t909839986 * value)
	{
		___targets_7 = value;
		Il2CppCodeGenWriteBarrier(&___targets_7, value);
	}

	inline static int32_t get_offset_of_delayedListFixups_8() { return static_cast<int32_t>(offsetof(XmlSerializationReader_t3551839386, ___delayedListFixups_8)); }
	inline Hashtable_t909839986 * get_delayedListFixups_8() const { return ___delayedListFixups_8; }
	inline Hashtable_t909839986 ** get_address_of_delayedListFixups_8() { return &___delayedListFixups_8; }
	inline void set_delayedListFixups_8(Hashtable_t909839986 * value)
	{
		___delayedListFixups_8 = value;
		Il2CppCodeGenWriteBarrier(&___delayedListFixups_8, value);
	}

	inline static int32_t get_offset_of_eventSource_9() { return static_cast<int32_t>(offsetof(XmlSerializationReader_t3551839386, ___eventSource_9)); }
	inline XmlSerializer_t1255294979 * get_eventSource_9() const { return ___eventSource_9; }
	inline XmlSerializer_t1255294979 ** get_address_of_eventSource_9() { return &___eventSource_9; }
	inline void set_eventSource_9(XmlSerializer_t1255294979 * value)
	{
		___eventSource_9 = value;
		Il2CppCodeGenWriteBarrier(&___eventSource_9, value);
	}

	inline static int32_t get_offset_of_delayedFixupId_10() { return static_cast<int32_t>(offsetof(XmlSerializationReader_t3551839386, ___delayedFixupId_10)); }
	inline int32_t get_delayedFixupId_10() const { return ___delayedFixupId_10; }
	inline int32_t* get_address_of_delayedFixupId_10() { return &___delayedFixupId_10; }
	inline void set_delayedFixupId_10(int32_t value)
	{
		___delayedFixupId_10 = value;
	}

	inline static int32_t get_offset_of_referencedObjects_11() { return static_cast<int32_t>(offsetof(XmlSerializationReader_t3551839386, ___referencedObjects_11)); }
	inline Hashtable_t909839986 * get_referencedObjects_11() const { return ___referencedObjects_11; }
	inline Hashtable_t909839986 ** get_address_of_referencedObjects_11() { return &___referencedObjects_11; }
	inline void set_referencedObjects_11(Hashtable_t909839986 * value)
	{
		___referencedObjects_11 = value;
		Il2CppCodeGenWriteBarrier(&___referencedObjects_11, value);
	}

	inline static int32_t get_offset_of_readCount_12() { return static_cast<int32_t>(offsetof(XmlSerializationReader_t3551839386, ___readCount_12)); }
	inline int32_t get_readCount_12() const { return ___readCount_12; }
	inline int32_t* get_address_of_readCount_12() { return &___readCount_12; }
	inline void set_readCount_12(int32_t value)
	{
		___readCount_12 = value;
	}

	inline static int32_t get_offset_of_whileIterationCount_13() { return static_cast<int32_t>(offsetof(XmlSerializationReader_t3551839386, ___whileIterationCount_13)); }
	inline int32_t get_whileIterationCount_13() const { return ___whileIterationCount_13; }
	inline int32_t* get_address_of_whileIterationCount_13() { return &___whileIterationCount_13; }
	inline void set_whileIterationCount_13(int32_t value)
	{
		___whileIterationCount_13 = value;
	}

	inline static int32_t get_offset_of_w3SchemaNS_14() { return static_cast<int32_t>(offsetof(XmlSerializationReader_t3551839386, ___w3SchemaNS_14)); }
	inline String_t* get_w3SchemaNS_14() const { return ___w3SchemaNS_14; }
	inline String_t** get_address_of_w3SchemaNS_14() { return &___w3SchemaNS_14; }
	inline void set_w3SchemaNS_14(String_t* value)
	{
		___w3SchemaNS_14 = value;
		Il2CppCodeGenWriteBarrier(&___w3SchemaNS_14, value);
	}

	inline static int32_t get_offset_of_w3InstanceNS_15() { return static_cast<int32_t>(offsetof(XmlSerializationReader_t3551839386, ___w3InstanceNS_15)); }
	inline String_t* get_w3InstanceNS_15() const { return ___w3InstanceNS_15; }
	inline String_t** get_address_of_w3InstanceNS_15() { return &___w3InstanceNS_15; }
	inline void set_w3InstanceNS_15(String_t* value)
	{
		___w3InstanceNS_15 = value;
		Il2CppCodeGenWriteBarrier(&___w3InstanceNS_15, value);
	}

	inline static int32_t get_offset_of_w3InstanceNS2000_16() { return static_cast<int32_t>(offsetof(XmlSerializationReader_t3551839386, ___w3InstanceNS2000_16)); }
	inline String_t* get_w3InstanceNS2000_16() const { return ___w3InstanceNS2000_16; }
	inline String_t** get_address_of_w3InstanceNS2000_16() { return &___w3InstanceNS2000_16; }
	inline void set_w3InstanceNS2000_16(String_t* value)
	{
		___w3InstanceNS2000_16 = value;
		Il2CppCodeGenWriteBarrier(&___w3InstanceNS2000_16, value);
	}

	inline static int32_t get_offset_of_w3InstanceNS1999_17() { return static_cast<int32_t>(offsetof(XmlSerializationReader_t3551839386, ___w3InstanceNS1999_17)); }
	inline String_t* get_w3InstanceNS1999_17() const { return ___w3InstanceNS1999_17; }
	inline String_t** get_address_of_w3InstanceNS1999_17() { return &___w3InstanceNS1999_17; }
	inline void set_w3InstanceNS1999_17(String_t* value)
	{
		___w3InstanceNS1999_17 = value;
		Il2CppCodeGenWriteBarrier(&___w3InstanceNS1999_17, value);
	}

	inline static int32_t get_offset_of_soapNS_18() { return static_cast<int32_t>(offsetof(XmlSerializationReader_t3551839386, ___soapNS_18)); }
	inline String_t* get_soapNS_18() const { return ___soapNS_18; }
	inline String_t** get_address_of_soapNS_18() { return &___soapNS_18; }
	inline void set_soapNS_18(String_t* value)
	{
		___soapNS_18 = value;
		Il2CppCodeGenWriteBarrier(&___soapNS_18, value);
	}

	inline static int32_t get_offset_of_wsdlNS_19() { return static_cast<int32_t>(offsetof(XmlSerializationReader_t3551839386, ___wsdlNS_19)); }
	inline String_t* get_wsdlNS_19() const { return ___wsdlNS_19; }
	inline String_t** get_address_of_wsdlNS_19() { return &___wsdlNS_19; }
	inline void set_wsdlNS_19(String_t* value)
	{
		___wsdlNS_19 = value;
		Il2CppCodeGenWriteBarrier(&___wsdlNS_19, value);
	}

	inline static int32_t get_offset_of_nullX_20() { return static_cast<int32_t>(offsetof(XmlSerializationReader_t3551839386, ___nullX_20)); }
	inline String_t* get_nullX_20() const { return ___nullX_20; }
	inline String_t** get_address_of_nullX_20() { return &___nullX_20; }
	inline void set_nullX_20(String_t* value)
	{
		___nullX_20 = value;
		Il2CppCodeGenWriteBarrier(&___nullX_20, value);
	}

	inline static int32_t get_offset_of_nil_21() { return static_cast<int32_t>(offsetof(XmlSerializationReader_t3551839386, ___nil_21)); }
	inline String_t* get_nil_21() const { return ___nil_21; }
	inline String_t** get_address_of_nil_21() { return &___nil_21; }
	inline void set_nil_21(String_t* value)
	{
		___nil_21 = value;
		Il2CppCodeGenWriteBarrier(&___nil_21, value);
	}

	inline static int32_t get_offset_of_typeX_22() { return static_cast<int32_t>(offsetof(XmlSerializationReader_t3551839386, ___typeX_22)); }
	inline String_t* get_typeX_22() const { return ___typeX_22; }
	inline String_t** get_address_of_typeX_22() { return &___typeX_22; }
	inline void set_typeX_22(String_t* value)
	{
		___typeX_22 = value;
		Il2CppCodeGenWriteBarrier(&___typeX_22, value);
	}

	inline static int32_t get_offset_of_arrayType_23() { return static_cast<int32_t>(offsetof(XmlSerializationReader_t3551839386, ___arrayType_23)); }
	inline String_t* get_arrayType_23() const { return ___arrayType_23; }
	inline String_t** get_address_of_arrayType_23() { return &___arrayType_23; }
	inline void set_arrayType_23(String_t* value)
	{
		___arrayType_23 = value;
		Il2CppCodeGenWriteBarrier(&___arrayType_23, value);
	}

	inline static int32_t get_offset_of_arrayQName_24() { return static_cast<int32_t>(offsetof(XmlSerializationReader_t3551839386, ___arrayQName_24)); }
	inline XmlQualifiedName_t1944712516 * get_arrayQName_24() const { return ___arrayQName_24; }
	inline XmlQualifiedName_t1944712516 ** get_address_of_arrayQName_24() { return &___arrayQName_24; }
	inline void set_arrayQName_24(XmlQualifiedName_t1944712516 * value)
	{
		___arrayQName_24 = value;
		Il2CppCodeGenWriteBarrier(&___arrayQName_24, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

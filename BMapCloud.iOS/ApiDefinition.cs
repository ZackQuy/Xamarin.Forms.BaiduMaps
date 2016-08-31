﻿using System;

using Foundation;
using ObjCRuntime;

namespace BMapCloud
{
	// @interface BMKCloudPOIList : NSObject
	[BaseType(typeof(NSObject))]
	interface BMKCloudPOIList
	{
		// @property (assign, nonatomic) NSInteger status;
		[Export("status")]
		nint Status { get; set; }

		// @property (assign, nonatomic) NSInteger total;
		[Export("total")]
		nint Total { get; set; }

		// @property (assign, nonatomic) NSInteger size;
		[Export("size")]
		nint Size { get; set; }

		// @property (assign, nonatomic) NSInteger pageNum;
		[Export("pageNum")]
		nint PageNum { get; set; }

		// @property (nonatomic, strong) NSArray * POIs;
		[Export("POIs", ArgumentSemantic.Strong)]
		//[Verify(StronglyTypedNSArray)]
		NSObject[] POIs { get; set; }
	}

	// @interface BMKCloudPOIInfo : NSObject
	[BaseType(typeof(NSObject))]
	interface BMKCloudPOIInfo
	{
		// @property (assign, nonatomic) int uid;
		[Export("uid")]
		int Uid { get; set; }

		// @property (assign, nonatomic) int geotableId;
		[Export("geotableId")]
		int GeotableId { get; set; }

		// @property (nonatomic, strong) NSString * title;
		[Export("title", ArgumentSemantic.Strong)]
		string Title { get; set; }

		// @property (nonatomic, strong) NSString * address;
		[Export("address", ArgumentSemantic.Strong)]
		string Address { get; set; }

		// @property (nonatomic, strong) NSString * province;
		[Export("province", ArgumentSemantic.Strong)]
		string Province { get; set; }

		// @property (nonatomic, strong) NSString * city;
		[Export("city", ArgumentSemantic.Strong)]
		string City { get; set; }

		// @property (nonatomic, strong) NSString * district;
		[Export("district", ArgumentSemantic.Strong)]
		string District { get; set; }

		// @property (assign, nonatomic) float latitude;
		[Export("latitude")]
		float Latitude { get; set; }

		// @property (assign, nonatomic) float longitude;
		[Export("longitude")]
		float Longitude { get; set; }

		// @property (nonatomic, strong) NSString * tags;
		[Export("tags", ArgumentSemantic.Strong)]
		string Tags { get; set; }

		// @property (assign, nonatomic) float distance;
		[Export("distance")]
		float Distance { get; set; }

		// @property (assign, nonatomic) float weight;
		[Export("weight")]
		float Weight { get; set; }

		// @property (nonatomic, strong) NSMutableDictionary * customDict;
		[Export("customDict", ArgumentSemantic.Strong)]
		NSMutableDictionary CustomDict { get; set; }

		// @property (assign, nonatomic) int creattime;
		[Export("creattime")]
		int Creattime { get; set; }

		// @property (assign, nonatomic) int modifytime;
		[Export("modifytime")]
		int Modifytime { get; set; }

		// @property (assign, nonatomic) int type;
		[Export("type")]
		int Type { get; set; }
	}

	// @interface BMKBaseCloudSearchInfo : NSObject
	[BaseType(typeof(NSObject))]
	interface BMKBaseCloudSearchInfo
	{
		// @property (nonatomic, strong) NSString * ak;
		[Export("ak", ArgumentSemantic.Strong)]
		string Ak { get; set; }

		// @property (nonatomic, strong) NSString * sn;
		[Export("sn", ArgumentSemantic.Strong)]
		string Sn { get; set; }

		// @property (assign, nonatomic) int geoTableId;
		[Export("geoTableId")]
		int GeoTableId { get; set; }
	}

	// @interface BMKCloudSearchInfo : BMKBaseCloudSearchInfo
	[BaseType(typeof(BMKBaseCloudSearchInfo))]
	interface BMKCloudSearchInfo
	{
		// @property (nonatomic, strong) NSString * keyword;
		[Export("keyword", ArgumentSemantic.Strong)]
		string Keyword { get; set; }

		// @property (nonatomic, strong) NSString * tags;
		[Export("tags", ArgumentSemantic.Strong)]
		string Tags { get; set; }

		// @property (nonatomic, strong) NSString * sortby;
		[Export("sortby", ArgumentSemantic.Strong)]
		string Sortby { get; set; }

		// @property (nonatomic, strong) NSString * filter;
		[Export("filter", ArgumentSemantic.Strong)]
		string Filter { get; set; }

		// @property (assign, nonatomic) NSInteger pageIndex;
		[Export("pageIndex")]
		nint PageIndex { get; set; }

		// @property (assign, nonatomic) NSInteger pageSize;
		[Export("pageSize")]
		nint PageSize { get; set; }
	}

	// @interface BMKCloudLocalSearchInfo : BMKCloudSearchInfo
	[BaseType(typeof(BMKCloudSearchInfo))]
	interface BMKCloudLocalSearchInfo
	{
		// @property (nonatomic, strong) NSString * region;
		[Export("region", ArgumentSemantic.Strong)]
		string Region { get; set; }
	}

	// @interface BMKCloudNearbySearchInfo : BMKCloudSearchInfo
	[BaseType(typeof(BMKCloudSearchInfo))]
	interface BMKCloudNearbySearchInfo
	{
		// @property (nonatomic, strong) NSString * location;
		[Export("location", ArgumentSemantic.Strong)]
		string Location { get; set; }

		// @property (assign, nonatomic) int radius;
		[Export("radius")]
		int Radius { get; set; }
	}

	// @interface BMKCloudBoundSearchInfo : BMKCloudSearchInfo
	[BaseType(typeof(BMKCloudSearchInfo))]
	interface BMKCloudBoundSearchInfo
	{
		// @property (nonatomic, strong) NSString * bounds;
		[Export("bounds", ArgumentSemantic.Strong)]
		string Bounds { get; set; }
	}

	// @interface BMKCloudDetailSearchInfo : BMKBaseCloudSearchInfo
	[BaseType(typeof(BMKBaseCloudSearchInfo))]
	interface BMKCloudDetailSearchInfo
	{
		// @property (nonatomic, strong) NSString * uid;
		[Export("uid", ArgumentSemantic.Strong)]
		string Uid { get; set; }
	}

	// @interface BMKCloudSearch : NSObject
	[BaseType(typeof(NSObject))]
	interface BMKCloudSearch
	{
		[Wrap("WeakDelegate")]
		BMKCloudSearchDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<BMKCloudSearchDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(BOOL)localSearchWithSearchInfo:(BMKCloudLocalSearchInfo *)searchInfo;
		[Export("localSearchWithSearchInfo:")]
		bool LocalSearchWithSearchInfo(BMKCloudLocalSearchInfo searchInfo);

		// -(BOOL)nearbySearchWithSearchInfo:(BMKCloudNearbySearchInfo *)searchInfo;
		[Export("nearbySearchWithSearchInfo:")]
		bool NearbySearchWithSearchInfo(BMKCloudNearbySearchInfo searchInfo);

		// -(BOOL)boundSearchWithSearchInfo:(BMKCloudBoundSearchInfo *)searchInfo;
		[Export("boundSearchWithSearchInfo:")]
		bool BoundSearchWithSearchInfo(BMKCloudBoundSearchInfo searchInfo);

		// -(BOOL)detailSearchWithSearchInfo:(BMKCloudDetailSearchInfo *)searchInfo;
		[Export("detailSearchWithSearchInfo:")]
		bool DetailSearchWithSearchInfo(BMKCloudDetailSearchInfo searchInfo);
	}

	// @protocol BMKCloudSearchDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface BMKCloudSearchDelegate
	{
		// @optional -(void)onGetCloudPoiResult:(NSArray *)poiResultList searchType:(int)type errorCode:(int)error;
		[Export("onGetCloudPoiResult:searchType:errorCode:")]
		//[Verify(StronglyTypedNSArray)]
		void OnGetCloudPoiResult(NSObject[] poiResultList, int type, int error);

		// @optional -(void)onGetCloudPoiDetailResult:(BMKCloudPOIInfo *)poiDetailResult searchType:(int)type errorCode:(int)error;
		[Export("onGetCloudPoiDetailResult:searchType:errorCode:")]
		void OnGetCloudPoiDetailResult(BMKCloudPOIInfo poiDetailResult, int type, int error);
	}

}

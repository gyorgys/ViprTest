namespace oneDrive

{

    using global::Microsoft.OData.Client;

    using global::Microsoft.OData.Edm;

    using System;

    using System.Collections.Generic;

    using System.ComponentModel;

    using System.Linq;

    using System.Reflection;

    using System.Threading.Tasks;

    public partial class itemReference:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _driveId;

        private System.String _id;

        private System.String _path;

        public System.String driveId

        {

            get

            {

                return _driveId;

            }

            set

            {

                if (value != _driveId)

                {

                    _driveId = value;

                    OnPropertyChanged("driveId");

                }

            }

        }

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        public System.String path

        {

            get

            {

                return _path;

            }

            set

            {

                if (value != _path)

                {

                    _path = value;

                    OnPropertyChanged("path");

                }

            }

        }

        public itemReference(): base()

        {

        }

    }

    public partial class uploadSession:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _uploadUrl;

        private System.Nullable<System.DateTimeOffset> _expirationDateTime;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _nextExpectedRanges;

        public System.String uploadUrl

        {

            get

            {

                return _uploadUrl;

            }

            set

            {

                if (value != _uploadUrl)

                {

                    _uploadUrl = value;

                    OnPropertyChanged("uploadUrl");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> expirationDateTime

        {

            get

            {

                return _expirationDateTime;

            }

            set

            {

                if (value != _expirationDateTime)

                {

                    _expirationDateTime = value;

                    OnPropertyChanged("expirationDateTime");

                }

            }

        }

        public System.Collections.Generic.IList<System.String> nextExpectedRanges

        {

            get

            {

                if (this._nextExpectedRanges == default(System.Collections.Generic.IList<System.String>))

                {

                    this._nextExpectedRanges = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._nextExpectedRanges.SetContainer(() => GetContainingEntity("nextExpectedRanges"));

                }

                return this._nextExpectedRanges;

            }

            set

            {

                nextExpectedRanges.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        nextExpectedRanges.Add(i);

                    }

                }

            }

        }

        public uploadSession(): base()

        {

        }

    }

    public partial class chunkedUploadSessionDescriptor:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _name;

        private System.Nullable<System.Int64> _size;

        public System.String name

        {

            get

            {

                return _name;

            }

            set

            {

                if (value != _name)

                {

                    _name = value;

                    OnPropertyChanged("name");

                }

            }

        }

        public System.Nullable<System.Int64> size

        {

            get

            {

                return _size;

            }

            set

            {

                if (value != _size)

                {

                    _size = value;

                    OnPropertyChanged("size");

                }

            }

        }

        public chunkedUploadSessionDescriptor(): base()

        {

        }

    }

    public partial class audio:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _album;

        private System.String _albumArtist;

        private System.String _artist;

        private System.Nullable<System.Int64> _bitrate;

        private System.String _composers;

        private System.String _copyright;

        private System.Nullable<System.Int32> _disc;

        private System.Nullable<System.Int32> _discCount;

        private System.Nullable<System.Int64> _duration;

        private System.String _genre;

        private System.Nullable<System.Boolean> _hasDrm;

        private System.Nullable<System.Boolean> _isVariableBitrate;

        private System.String _title;

        private System.Nullable<System.Int64> _track;

        private System.Nullable<System.Int64> _trackCount;

        private System.Nullable<System.Int64> _year;

        public System.String album

        {

            get

            {

                return _album;

            }

            set

            {

                if (value != _album)

                {

                    _album = value;

                    OnPropertyChanged("album");

                }

            }

        }

        public System.String albumArtist

        {

            get

            {

                return _albumArtist;

            }

            set

            {

                if (value != _albumArtist)

                {

                    _albumArtist = value;

                    OnPropertyChanged("albumArtist");

                }

            }

        }

        public System.String artist

        {

            get

            {

                return _artist;

            }

            set

            {

                if (value != _artist)

                {

                    _artist = value;

                    OnPropertyChanged("artist");

                }

            }

        }

        public System.Nullable<System.Int64> bitrate

        {

            get

            {

                return _bitrate;

            }

            set

            {

                if (value != _bitrate)

                {

                    _bitrate = value;

                    OnPropertyChanged("bitrate");

                }

            }

        }

        public System.String composers

        {

            get

            {

                return _composers;

            }

            set

            {

                if (value != _composers)

                {

                    _composers = value;

                    OnPropertyChanged("composers");

                }

            }

        }

        public System.String copyright

        {

            get

            {

                return _copyright;

            }

            set

            {

                if (value != _copyright)

                {

                    _copyright = value;

                    OnPropertyChanged("copyright");

                }

            }

        }

        public System.Nullable<System.Int32> disc

        {

            get

            {

                return _disc;

            }

            set

            {

                if (value != _disc)

                {

                    _disc = value;

                    OnPropertyChanged("disc");

                }

            }

        }

        public System.Nullable<System.Int32> discCount

        {

            get

            {

                return _discCount;

            }

            set

            {

                if (value != _discCount)

                {

                    _discCount = value;

                    OnPropertyChanged("discCount");

                }

            }

        }

        public System.Nullable<System.Int64> duration

        {

            get

            {

                return _duration;

            }

            set

            {

                if (value != _duration)

                {

                    _duration = value;

                    OnPropertyChanged("duration");

                }

            }

        }

        public System.String genre

        {

            get

            {

                return _genre;

            }

            set

            {

                if (value != _genre)

                {

                    _genre = value;

                    OnPropertyChanged("genre");

                }

            }

        }

        public System.Nullable<System.Boolean> hasDrm

        {

            get

            {

                return _hasDrm;

            }

            set

            {

                if (value != _hasDrm)

                {

                    _hasDrm = value;

                    OnPropertyChanged("hasDrm");

                }

            }

        }

        public System.Nullable<System.Boolean> isVariableBitrate

        {

            get

            {

                return _isVariableBitrate;

            }

            set

            {

                if (value != _isVariableBitrate)

                {

                    _isVariableBitrate = value;

                    OnPropertyChanged("isVariableBitrate");

                }

            }

        }

        public System.String title

        {

            get

            {

                return _title;

            }

            set

            {

                if (value != _title)

                {

                    _title = value;

                    OnPropertyChanged("title");

                }

            }

        }

        public System.Nullable<System.Int64> track

        {

            get

            {

                return _track;

            }

            set

            {

                if (value != _track)

                {

                    _track = value;

                    OnPropertyChanged("track");

                }

            }

        }

        public System.Nullable<System.Int64> trackCount

        {

            get

            {

                return _trackCount;

            }

            set

            {

                if (value != _trackCount)

                {

                    _trackCount = value;

                    OnPropertyChanged("trackCount");

                }

            }

        }

        public System.Nullable<System.Int64> year

        {

            get

            {

                return _year;

            }

            set

            {

                if (value != _year)

                {

                    _year = value;

                    OnPropertyChanged("year");

                }

            }

        }

        public audio(): base()

        {

        }

    }

    public partial class deleted:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _state;

        public System.String state

        {

            get

            {

                return _state;

            }

            set

            {

                if (value != _state)

                {

                    _state = value;

                    OnPropertyChanged("state");

                }

            }

        }

        public deleted(): base()

        {

        }

    }

    public partial class file:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private global::oneDrive.hashes _hashes;

        private System.String _mimeType;

        public global::oneDrive.hashes hashes

        {

            get

            {

                return _hashes;

            }

            set

            {

                if (value != _hashes)

                {

                    _hashes = value;

                    OnPropertyChanged("hashes");

                }

            }

        }

        public System.String mimeType

        {

            get

            {

                return _mimeType;

            }

            set

            {

                if (value != _mimeType)

                {

                    _mimeType = value;

                    OnPropertyChanged("mimeType");

                }

            }

        }

        public file(): base()

        {

        }

    }

    public partial class folder:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.Nullable<System.Int32> _childCount;

        public System.Nullable<System.Int32> childCount

        {

            get

            {

                return _childCount;

            }

            set

            {

                if (value != _childCount)

                {

                    _childCount = value;

                    OnPropertyChanged("childCount");

                }

            }

        }

        public folder(): base()

        {

        }

    }

    public partial class hashes:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _crc32Hash;

        private System.String _sha1Hash;

        public System.String crc32Hash

        {

            get

            {

                return _crc32Hash;

            }

            set

            {

                if (value != _crc32Hash)

                {

                    _crc32Hash = value;

                    OnPropertyChanged("crc32Hash");

                }

            }

        }

        public System.String sha1Hash

        {

            get

            {

                return _sha1Hash;

            }

            set

            {

                if (value != _sha1Hash)

                {

                    _sha1Hash = value;

                    OnPropertyChanged("sha1Hash");

                }

            }

        }

        public hashes(): base()

        {

        }

    }

    public partial class image:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.Nullable<System.Int32> _height;

        private System.Nullable<System.Int32> _width;

        public System.Nullable<System.Int32> height

        {

            get

            {

                return _height;

            }

            set

            {

                if (value != _height)

                {

                    _height = value;

                    OnPropertyChanged("height");

                }

            }

        }

        public System.Nullable<System.Int32> width

        {

            get

            {

                return _width;

            }

            set

            {

                if (value != _width)

                {

                    _width = value;

                    OnPropertyChanged("width");

                }

            }

        }

        public image(): base()

        {

        }

    }

    public partial class location:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.Nullable<System.Double> _altitude;

        private System.Nullable<System.Double> _latitude;

        private System.Nullable<System.Double> _longitude;

        public System.Nullable<System.Double> altitude

        {

            get

            {

                return _altitude;

            }

            set

            {

                if (value != _altitude)

                {

                    _altitude = value;

                    OnPropertyChanged("altitude");

                }

            }

        }

        public System.Nullable<System.Double> latitude

        {

            get

            {

                return _latitude;

            }

            set

            {

                if (value != _latitude)

                {

                    _latitude = value;

                    OnPropertyChanged("latitude");

                }

            }

        }

        public System.Nullable<System.Double> longitude

        {

            get

            {

                return _longitude;

            }

            set

            {

                if (value != _longitude)

                {

                    _longitude = value;

                    OnPropertyChanged("longitude");

                }

            }

        }

        public location(): base()

        {

        }

    }

    public partial class photo:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _cameraMake;

        private System.String _cameraModel;

        private System.Nullable<System.Double> _exposureDenominator;

        private System.Nullable<System.Double> _exposureNumerator;

        private System.Nullable<System.Double> _focalLength;

        private System.Nullable<System.Double> _fNumber;

        private System.Nullable<System.DateTimeOffset> _takenDateTime;

        public System.String cameraMake

        {

            get

            {

                return _cameraMake;

            }

            set

            {

                if (value != _cameraMake)

                {

                    _cameraMake = value;

                    OnPropertyChanged("cameraMake");

                }

            }

        }

        public System.String cameraModel

        {

            get

            {

                return _cameraModel;

            }

            set

            {

                if (value != _cameraModel)

                {

                    _cameraModel = value;

                    OnPropertyChanged("cameraModel");

                }

            }

        }

        public System.Nullable<System.Double> exposureDenominator

        {

            get

            {

                return _exposureDenominator;

            }

            set

            {

                if (value != _exposureDenominator)

                {

                    _exposureDenominator = value;

                    OnPropertyChanged("exposureDenominator");

                }

            }

        }

        public System.Nullable<System.Double> exposureNumerator

        {

            get

            {

                return _exposureNumerator;

            }

            set

            {

                if (value != _exposureNumerator)

                {

                    _exposureNumerator = value;

                    OnPropertyChanged("exposureNumerator");

                }

            }

        }

        public System.Nullable<System.Double> focalLength

        {

            get

            {

                return _focalLength;

            }

            set

            {

                if (value != _focalLength)

                {

                    _focalLength = value;

                    OnPropertyChanged("focalLength");

                }

            }

        }

        public System.Nullable<System.Double> fNumber

        {

            get

            {

                return _fNumber;

            }

            set

            {

                if (value != _fNumber)

                {

                    _fNumber = value;

                    OnPropertyChanged("fNumber");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> takenDateTime

        {

            get

            {

                return _takenDateTime;

            }

            set

            {

                if (value != _takenDateTime)

                {

                    _takenDateTime = value;

                    OnPropertyChanged("takenDateTime");

                }

            }

        }

        public photo(): base()

        {

        }

    }

    public partial class quota:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.Nullable<System.Int64> _deleted;

        private System.Nullable<System.Int64> _remaining;

        private System.String _state;

        private System.Nullable<System.Int64> _total;

        private System.Nullable<System.Int64> _used;

        public System.Nullable<System.Int64> deleted

        {

            get

            {

                return _deleted;

            }

            set

            {

                if (value != _deleted)

                {

                    _deleted = value;

                    OnPropertyChanged("deleted");

                }

            }

        }

        public System.Nullable<System.Int64> remaining

        {

            get

            {

                return _remaining;

            }

            set

            {

                if (value != _remaining)

                {

                    _remaining = value;

                    OnPropertyChanged("remaining");

                }

            }

        }

        public System.String state

        {

            get

            {

                return _state;

            }

            set

            {

                if (value != _state)

                {

                    _state = value;

                    OnPropertyChanged("state");

                }

            }

        }

        public System.Nullable<System.Int64> total

        {

            get

            {

                return _total;

            }

            set

            {

                if (value != _total)

                {

                    _total = value;

                    OnPropertyChanged("total");

                }

            }

        }

        public System.Nullable<System.Int64> used

        {

            get

            {

                return _used;

            }

            set

            {

                if (value != _used)

                {

                    _used = value;

                    OnPropertyChanged("used");

                }

            }

        }

        public quota(): base()

        {

        }

    }

    public partial class sharingInvitation:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _email;

        private System.String _redeemedBy;

        private System.Nullable<System.Boolean> _signInRequired;

        public System.String email

        {

            get

            {

                return _email;

            }

            set

            {

                if (value != _email)

                {

                    _email = value;

                    OnPropertyChanged("email");

                }

            }

        }

        public System.String redeemedBy

        {

            get

            {

                return _redeemedBy;

            }

            set

            {

                if (value != _redeemedBy)

                {

                    _redeemedBy = value;

                    OnPropertyChanged("redeemedBy");

                }

            }

        }

        public System.Nullable<System.Boolean> signInRequired

        {

            get

            {

                return _signInRequired;

            }

            set

            {

                if (value != _signInRequired)

                {

                    _signInRequired = value;

                    OnPropertyChanged("signInRequired");

                }

            }

        }

        public sharingInvitation(): base()

        {

        }

    }

    public partial class sharingLink:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private global::oneDrive.identity _application;

        private System.String _token;

        private System.String _type;

        private System.String _webUrl;

        public global::oneDrive.identity application

        {

            get

            {

                return _application;

            }

            set

            {

                if (value != _application)

                {

                    _application = value;

                    OnPropertyChanged("application");

                }

            }

        }

        public System.String token

        {

            get

            {

                return _token;

            }

            set

            {

                if (value != _token)

                {

                    _token = value;

                    OnPropertyChanged("token");

                }

            }

        }

        public System.String type

        {

            get

            {

                return _type;

            }

            set

            {

                if (value != _type)

                {

                    _type = value;

                    OnPropertyChanged("type");

                }

            }

        }

        public System.String webUrl

        {

            get

            {

                return _webUrl;

            }

            set

            {

                if (value != _webUrl)

                {

                    _webUrl = value;

                    OnPropertyChanged("webUrl");

                }

            }

        }

        public sharingLink(): base()

        {

        }

    }

    public partial class specialFolder:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _name;

        public System.String name

        {

            get

            {

                return _name;

            }

            set

            {

                if (value != _name)

                {

                    _name = value;

                    OnPropertyChanged("name");

                }

            }

        }

        public specialFolder(): base()

        {

        }

    }

    public partial class video:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.Nullable<System.Int64> _bitrate;

        private System.Nullable<System.Int64> _duration;

        private System.Nullable<System.Int64> _height;

        private System.Nullable<System.Int64> _width;

        public System.Nullable<System.Int64> bitrate

        {

            get

            {

                return _bitrate;

            }

            set

            {

                if (value != _bitrate)

                {

                    _bitrate = value;

                    OnPropertyChanged("bitrate");

                }

            }

        }

        public System.Nullable<System.Int64> duration

        {

            get

            {

                return _duration;

            }

            set

            {

                if (value != _duration)

                {

                    _duration = value;

                    OnPropertyChanged("duration");

                }

            }

        }

        public System.Nullable<System.Int64> height

        {

            get

            {

                return _height;

            }

            set

            {

                if (value != _height)

                {

                    _height = value;

                    OnPropertyChanged("height");

                }

            }

        }

        public System.Nullable<System.Int64> width

        {

            get

            {

                return _width;

            }

            set

            {

                if (value != _width)

                {

                    _width = value;

                    OnPropertyChanged("width");

                }

            }

        }

        public video(): base()

        {

        }

    }

    public partial class identitySet:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private global::oneDrive.identity _application;

        private global::oneDrive.identity _device;

        private global::oneDrive.identity _user;

        public global::oneDrive.identity application

        {

            get

            {

                return _application;

            }

            set

            {

                if (value != _application)

                {

                    _application = value;

                    OnPropertyChanged("application");

                }

            }

        }

        public global::oneDrive.identity device

        {

            get

            {

                return _device;

            }

            set

            {

                if (value != _device)

                {

                    _device = value;

                    OnPropertyChanged("device");

                }

            }

        }

        public global::oneDrive.identity user

        {

            get

            {

                return _user;

            }

            set

            {

                if (value != _user)

                {

                    _user = value;

                    OnPropertyChanged("user");

                }

            }

        }

        public identitySet(): base()

        {

        }

    }

    public partial class identity:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private System.String _displayName;

        private System.String _id;

        public System.String displayName

        {

            get

            {

                return _displayName;

            }

            set

            {

                if (value != _displayName)

                {

                    _displayName = value;

                    OnPropertyChanged("displayName");

                }

            }

        }

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        public identity(): base()

        {

        }

    }

    public partial class thumbnail:Microsoft.OData.ProxyExtensions.ComplexTypeBase

    {

        private Microsoft.OData.Client.DataServiceStreamLink _content;

        private System.Nullable<System.Int32> _height;

        private System.String _url;

        private System.Nullable<System.Int32> _width;

        public Microsoft.OData.Client.DataServiceStreamLink content

        {

            get

            {

                return _content;

            }

            set

            {

                if (value != _content)

                {

                    _content = value;

                    OnPropertyChanged("content");

                }

            }

        }

        public System.Nullable<System.Int32> height

        {

            get

            {

                return _height;

            }

            set

            {

                if (value != _height)

                {

                    _height = value;

                    OnPropertyChanged("height");

                }

            }

        }

        public System.String url

        {

            get

            {

                return _url;

            }

            set

            {

                if (value != _url)

                {

                    _url = value;

                    OnPropertyChanged("url");

                }

            }

        }

        public System.Nullable<System.Int32> width

        {

            get

            {

                return _width;

            }

            set

            {

                if (value != _width)

                {

                    _width = value;

                    OnPropertyChanged("width");

                }

            }

        }

        public thumbnail(): base()

        {

        }

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class drive:Microsoft.OData.ProxyExtensions.EntityBase, global::oneDrive.Idrive, global::oneDrive.IdriveFetcher

    {

        private global::oneDrive.itemCollection _itemsCollection;

        private global::oneDrive.itemCollection _sharedCollection;

        private global::oneDrive.itemCollection _specialCollection;

        private System.String _id;

        private System.String _driveType;

        private global::oneDrive.identitySet _owner;

        private global::oneDrive.quota _quota;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::oneDrive.item> _itemsConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::oneDrive.item> _sharedConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::oneDrive.item> _specialConcrete;

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        public System.String driveType

        {

            get

            {

                return _driveType;

            }

            set

            {

                if (value != _driveType)

                {

                    _driveType = value;

                    OnPropertyChanged("driveType");

                }

            }

        }

        public global::oneDrive.identitySet owner

        {

            get

            {

                return _owner;

            }

            set

            {

                if (value != _owner)

                {

                    _owner = value;

                    OnPropertyChanged("owner");

                }

            }

        }

        public global::oneDrive.quota quota

        {

            get

            {

                return _quota;

            }

            set

            {

                if (value != _quota)

                {

                    _quota = value;

                    OnPropertyChanged("quota");

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::oneDrive.Iitem> global::oneDrive.Idrive.items

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::oneDrive.Iitem, global::oneDrive.item>(Context, (DataServiceCollection<global::oneDrive.item>) items);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::oneDrive.Iitem> global::oneDrive.Idrive.shared

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::oneDrive.Iitem, global::oneDrive.item>(Context, (DataServiceCollection<global::oneDrive.item>) shared);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::oneDrive.Iitem> global::oneDrive.Idrive.special

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::oneDrive.Iitem, global::oneDrive.item>(Context, (DataServiceCollection<global::oneDrive.item>) special);

            }

        }

        public global::System.Collections.Generic.IList<global::oneDrive.item> items

        {

            get

            {

                if (this._itemsConcrete == null)

                {

                    this._itemsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::oneDrive.item>();

                    this._itemsConcrete.SetContainer(() => GetContainingEntity("items"));

                }

                

                return (global::System.Collections.Generic.IList<global::oneDrive.item>)this._itemsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                items.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        items.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::oneDrive.item> shared

        {

            get

            {

                if (this._sharedConcrete == null)

                {

                    this._sharedConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::oneDrive.item>();

                    this._sharedConcrete.SetContainer(() => GetContainingEntity("shared"));

                }

                

                return (global::System.Collections.Generic.IList<global::oneDrive.item>)this._sharedConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                shared.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        shared.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::oneDrive.item> special

        {

            get

            {

                if (this._specialConcrete == null)

                {

                    this._specialConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::oneDrive.item>();

                    this._specialConcrete.SetContainer(() => GetContainingEntity("special"));

                }

                

                return (global::System.Collections.Generic.IList<global::oneDrive.item>)this._specialConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                special.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        special.Add(i);

                    }

                }

            }

        }

        global::oneDrive.IitemCollection global::oneDrive.IdriveFetcher.items

        {

            get

            {

                if (this._itemsCollection == null)

                {

                    this._itemsCollection = new global::oneDrive.itemCollection(
                       Context != null ? Context.CreateQuery<global::oneDrive.item>(GetPath("items")) : null,
                       Context,
                       this,
                       GetPath("items"));

                }

                

                return this._itemsCollection;

            }

        }

        global::oneDrive.IitemCollection global::oneDrive.IdriveFetcher.shared

        {

            get

            {

                if (this._sharedCollection == null)

                {

                    this._sharedCollection = new global::oneDrive.itemCollection(
                       Context != null ? Context.CreateQuery<global::oneDrive.item>(GetPath("shared")) : null,
                       Context,
                       this,
                       GetPath("shared"));

                }

                

                return this._sharedCollection;

            }

        }

        global::oneDrive.IitemCollection global::oneDrive.IdriveFetcher.special

        {

            get

            {

                if (this._specialCollection == null)

                {

                    this._specialCollection = new global::oneDrive.itemCollection(
                       Context != null ? Context.CreateQuery<global::oneDrive.item>(GetPath("special")) : null,
                       Context,
                       this,
                       GetPath("special"));

                }

                

                return this._specialCollection;

            }

        }

        public drive(): base()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::oneDrive.Idrive> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::oneDrive.drive, global::oneDrive.Idrive>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::oneDrive.Idrive> _query;

        global::System.Threading.Tasks.Task<global::oneDrive.Idrive> global::oneDrive.IdriveFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::oneDrive.Idrive>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::oneDrive.IdriveFetcher global::oneDrive.IdriveFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::oneDrive.Idrive, TTarget>> navigationPropertyAccessor)

        {

            return (global::oneDrive.IdriveFetcher) this;

        }

    }

    internal partial class driveFetcher:Microsoft.OData.ProxyExtensions.RestShallowObjectFetcher, global::oneDrive.IdriveFetcher

    {

        private global::oneDrive.itemCollection _itemsCollection;

        private global::oneDrive.itemCollection _sharedCollection;

        private global::oneDrive.itemCollection _specialCollection;

        public global::oneDrive.IitemCollection items

        {

            get

            {

                if (this._itemsCollection == null)

                {

                    this._itemsCollection = new global::oneDrive.itemCollection(
                       Context != null ? Context.CreateQuery<global::oneDrive.item>(GetPath("items")) : null,
                       Context,
                       this,
                       GetPath("items"));

                }

                

                return this._itemsCollection;

            }

        }

        public global::oneDrive.IitemCollection shared

        {

            get

            {

                if (this._sharedCollection == null)

                {

                    this._sharedCollection = new global::oneDrive.itemCollection(
                       Context != null ? Context.CreateQuery<global::oneDrive.item>(GetPath("shared")) : null,
                       Context,
                       this,
                       GetPath("shared"));

                }

                

                return this._sharedCollection;

            }

        }

        public global::oneDrive.IitemCollection special

        {

            get

            {

                if (this._specialCollection == null)

                {

                    this._specialCollection = new global::oneDrive.itemCollection(
                       Context != null ? Context.CreateQuery<global::oneDrive.item>(GetPath("special")) : null,
                       Context,
                       this,
                       GetPath("special"));

                }

                

                return this._specialCollection;

            }

        }

        public driveFetcher(): base()

        {

        }

        public async global::System.Threading.Tasks.Task<global::oneDrive.Idrive> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::oneDrive.IdriveFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::oneDrive.Idrive, TTarget>> navigationPropertyAccessor)

        {

            return (global::oneDrive.IdriveFetcher) new global::oneDrive.driveFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::oneDrive.Idrive> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::oneDrive.drive, global::oneDrive.Idrive>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::oneDrive.Idrive> _query;

    }

    internal partial class driveCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::oneDrive.Idrive>, global::oneDrive.IdriveCollection

    {

        internal driveCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::oneDrive.IdriveFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::oneDrive.Idrive>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AdddriveAsync(global::oneDrive.Idrive item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::oneDrive.IdriveFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::oneDrive.drive>((i) => i.id == id);

                var fetcher = new global::oneDrive.driveFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class driveCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    internal partial class driveFetcher

    {

    }

    public partial class drive

    {

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class item:Microsoft.OData.ProxyExtensions.EntityBase, global::oneDrive.Iitem, global::oneDrive.IitemFetcher

    {

        private global::oneDrive.itemCollection _childrenCollection;

        private global::oneDrive.permissionCollection _permissionsCollection;

        private global::oneDrive.thumbnailSetCollection _thumbnailsCollection;

        private Microsoft.OData.Client.DataServiceStreamLink _content;

        private global::oneDrive.identitySet _createdBy;

        private System.Nullable<System.DateTimeOffset> _createdDateTime;

        private System.String _cTag;

        private System.String _eTag;

        private System.String _id;

        private global::oneDrive.identitySet _lastModifiedBy;

        private System.Nullable<System.DateTimeOffset> _lastModifiedDateTime;

        private System.String _name;

        private global::oneDrive.itemReference _parentReference;

        private System.Nullable<System.Int64> _size;

        private System.String _webUrl;

        private global::oneDrive.audio _audio;

        private global::oneDrive.deleted _deleted;

        private global::oneDrive.file _file;

        private global::oneDrive.folder _folder;

        private global::oneDrive.image _image;

        private global::oneDrive.location _location;

        private global::oneDrive.photo _photo;

        private global::oneDrive.specialFolder _specialFolder;

        private global::oneDrive.video _video;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::oneDrive.item> _childrenConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::oneDrive.permission> _permissionsConcrete;

        private Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::oneDrive.thumbnailSet> _thumbnailsConcrete;

        public Microsoft.OData.Client.DataServiceStreamLink content

        {

            get

            {

                return _content;

            }

            set

            {

                if (value != _content)

                {

                    _content = value;

                    OnPropertyChanged("content");

                }

            }

        }

        public global::oneDrive.identitySet createdBy

        {

            get

            {

                return _createdBy;

            }

            set

            {

                if (value != _createdBy)

                {

                    _createdBy = value;

                    OnPropertyChanged("createdBy");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> createdDateTime

        {

            get

            {

                return _createdDateTime;

            }

            set

            {

                if (value != _createdDateTime)

                {

                    _createdDateTime = value;

                    OnPropertyChanged("createdDateTime");

                }

            }

        }

        public System.String cTag

        {

            get

            {

                return _cTag;

            }

            set

            {

                if (value != _cTag)

                {

                    _cTag = value;

                    OnPropertyChanged("cTag");

                }

            }

        }

        public System.String eTag

        {

            get

            {

                return _eTag;

            }

            set

            {

                if (value != _eTag)

                {

                    _eTag = value;

                    OnPropertyChanged("eTag");

                }

            }

        }

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        public global::oneDrive.identitySet lastModifiedBy

        {

            get

            {

                return _lastModifiedBy;

            }

            set

            {

                if (value != _lastModifiedBy)

                {

                    _lastModifiedBy = value;

                    OnPropertyChanged("lastModifiedBy");

                }

            }

        }

        public System.Nullable<System.DateTimeOffset> lastModifiedDateTime

        {

            get

            {

                return _lastModifiedDateTime;

            }

            set

            {

                if (value != _lastModifiedDateTime)

                {

                    _lastModifiedDateTime = value;

                    OnPropertyChanged("lastModifiedDateTime");

                }

            }

        }

        public System.String name

        {

            get

            {

                return _name;

            }

            set

            {

                if (value != _name)

                {

                    _name = value;

                    OnPropertyChanged("name");

                }

            }

        }

        public global::oneDrive.itemReference parentReference

        {

            get

            {

                return _parentReference;

            }

            set

            {

                if (value != _parentReference)

                {

                    _parentReference = value;

                    OnPropertyChanged("parentReference");

                }

            }

        }

        public System.Nullable<System.Int64> size

        {

            get

            {

                return _size;

            }

            set

            {

                if (value != _size)

                {

                    _size = value;

                    OnPropertyChanged("size");

                }

            }

        }

        public System.String webUrl

        {

            get

            {

                return _webUrl;

            }

            set

            {

                if (value != _webUrl)

                {

                    _webUrl = value;

                    OnPropertyChanged("webUrl");

                }

            }

        }

        public global::oneDrive.audio audio

        {

            get

            {

                return _audio;

            }

            set

            {

                if (value != _audio)

                {

                    _audio = value;

                    OnPropertyChanged("audio");

                }

            }

        }

        public global::oneDrive.deleted deleted

        {

            get

            {

                return _deleted;

            }

            set

            {

                if (value != _deleted)

                {

                    _deleted = value;

                    OnPropertyChanged("deleted");

                }

            }

        }

        public global::oneDrive.file file

        {

            get

            {

                return _file;

            }

            set

            {

                if (value != _file)

                {

                    _file = value;

                    OnPropertyChanged("file");

                }

            }

        }

        public global::oneDrive.folder folder

        {

            get

            {

                return _folder;

            }

            set

            {

                if (value != _folder)

                {

                    _folder = value;

                    OnPropertyChanged("folder");

                }

            }

        }

        public global::oneDrive.image image

        {

            get

            {

                return _image;

            }

            set

            {

                if (value != _image)

                {

                    _image = value;

                    OnPropertyChanged("image");

                }

            }

        }

        public global::oneDrive.location location

        {

            get

            {

                return _location;

            }

            set

            {

                if (value != _location)

                {

                    _location = value;

                    OnPropertyChanged("location");

                }

            }

        }

        public global::oneDrive.photo photo

        {

            get

            {

                return _photo;

            }

            set

            {

                if (value != _photo)

                {

                    _photo = value;

                    OnPropertyChanged("photo");

                }

            }

        }

        public global::oneDrive.specialFolder specialFolder

        {

            get

            {

                return _specialFolder;

            }

            set

            {

                if (value != _specialFolder)

                {

                    _specialFolder = value;

                    OnPropertyChanged("specialFolder");

                }

            }

        }

        public global::oneDrive.video video

        {

            get

            {

                return _video;

            }

            set

            {

                if (value != _video)

                {

                    _video = value;

                    OnPropertyChanged("video");

                }

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::oneDrive.Iitem> global::oneDrive.Iitem.children

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::oneDrive.Iitem, global::oneDrive.item>(Context, (DataServiceCollection<global::oneDrive.item>) children);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::oneDrive.Ipermission> global::oneDrive.Iitem.permissions

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::oneDrive.Ipermission, global::oneDrive.permission>(Context, (DataServiceCollection<global::oneDrive.permission>) permissions);

            }

        }

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::oneDrive.IthumbnailSet> global::oneDrive.Iitem.thumbnails

        {

            get

            {

                return new Microsoft.OData.ProxyExtensions.PagedCollection<global::oneDrive.IthumbnailSet, global::oneDrive.thumbnailSet>(Context, (DataServiceCollection<global::oneDrive.thumbnailSet>) thumbnails);

            }

        }

        public global::System.Collections.Generic.IList<global::oneDrive.item> children

        {

            get

            {

                if (this._childrenConcrete == null)

                {

                    this._childrenConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::oneDrive.item>();

                    this._childrenConcrete.SetContainer(() => GetContainingEntity("children"));

                }

                

                return (global::System.Collections.Generic.IList<global::oneDrive.item>)this._childrenConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                children.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        children.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::oneDrive.permission> permissions

        {

            get

            {

                if (this._permissionsConcrete == null)

                {

                    this._permissionsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::oneDrive.permission>();

                    this._permissionsConcrete.SetContainer(() => GetContainingEntity("permissions"));

                }

                

                return (global::System.Collections.Generic.IList<global::oneDrive.permission>)this._permissionsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                permissions.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        permissions.Add(i);

                    }

                }

            }

        }

        public global::System.Collections.Generic.IList<global::oneDrive.thumbnailSet> thumbnails

        {

            get

            {

                if (this._thumbnailsConcrete == null)

                {

                    this._thumbnailsConcrete = new Microsoft.OData.ProxyExtensions.EntityCollectionImpl<global::oneDrive.thumbnailSet>();

                    this._thumbnailsConcrete.SetContainer(() => GetContainingEntity("thumbnails"));

                }

                

                return (global::System.Collections.Generic.IList<global::oneDrive.thumbnailSet>)this._thumbnailsConcrete;

            }

            set

            {

                if (this.Context == null)

                    throw new InvalidOperationException("Not Initialized");

                thumbnails.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        thumbnails.Add(i);

                    }

                }

            }

        }

        global::oneDrive.IitemCollection global::oneDrive.IitemFetcher.children

        {

            get

            {

                if (this._childrenCollection == null)

                {

                    this._childrenCollection = new global::oneDrive.itemCollection(
                       Context != null ? Context.CreateQuery<global::oneDrive.item>(GetPath("children")) : null,
                       Context,
                       this,
                       GetPath("children"));

                }

                

                return this._childrenCollection;

            }

        }

        global::oneDrive.IpermissionCollection global::oneDrive.IitemFetcher.permissions

        {

            get

            {

                if (this._permissionsCollection == null)

                {

                    this._permissionsCollection = new global::oneDrive.permissionCollection(
                       Context != null ? Context.CreateQuery<global::oneDrive.permission>(GetPath("permissions")) : null,
                       Context,
                       this,
                       GetPath("permissions"));

                }

                

                return this._permissionsCollection;

            }

        }

        global::oneDrive.IthumbnailSetCollection global::oneDrive.IitemFetcher.thumbnails

        {

            get

            {

                if (this._thumbnailsCollection == null)

                {

                    this._thumbnailsCollection = new global::oneDrive.thumbnailSetCollection(
                       Context != null ? Context.CreateQuery<global::oneDrive.thumbnailSet>(GetPath("thumbnails")) : null,
                       Context,
                       this,
                       GetPath("thumbnails"));

                }

                

                return this._thumbnailsCollection;

            }

        }

        public item(): base()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::oneDrive.Iitem> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::oneDrive.item, global::oneDrive.Iitem>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::oneDrive.Iitem> _query;

        global::System.Threading.Tasks.Task<global::oneDrive.Iitem> global::oneDrive.IitemFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::oneDrive.Iitem>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::oneDrive.IitemFetcher global::oneDrive.IitemFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::oneDrive.Iitem, TTarget>> navigationPropertyAccessor)

        {

            return (global::oneDrive.IitemFetcher) this;

        }

    }

    internal partial class itemFetcher:Microsoft.OData.ProxyExtensions.RestShallowObjectFetcher, global::oneDrive.IitemFetcher

    {

        private global::oneDrive.itemCollection _childrenCollection;

        private global::oneDrive.permissionCollection _permissionsCollection;

        private global::oneDrive.thumbnailSetCollection _thumbnailsCollection;

        public global::oneDrive.IitemCollection children

        {

            get

            {

                if (this._childrenCollection == null)

                {

                    this._childrenCollection = new global::oneDrive.itemCollection(
                       Context != null ? Context.CreateQuery<global::oneDrive.item>(GetPath("children")) : null,
                       Context,
                       this,
                       GetPath("children"));

                }

                

                return this._childrenCollection;

            }

        }

        public global::oneDrive.IpermissionCollection permissions

        {

            get

            {

                if (this._permissionsCollection == null)

                {

                    this._permissionsCollection = new global::oneDrive.permissionCollection(
                       Context != null ? Context.CreateQuery<global::oneDrive.permission>(GetPath("permissions")) : null,
                       Context,
                       this,
                       GetPath("permissions"));

                }

                

                return this._permissionsCollection;

            }

        }

        public global::oneDrive.IthumbnailSetCollection thumbnails

        {

            get

            {

                if (this._thumbnailsCollection == null)

                {

                    this._thumbnailsCollection = new global::oneDrive.thumbnailSetCollection(
                       Context != null ? Context.CreateQuery<global::oneDrive.thumbnailSet>(GetPath("thumbnails")) : null,
                       Context,
                       this,
                       GetPath("thumbnails"));

                }

                

                return this._thumbnailsCollection;

            }

        }

        public itemFetcher(): base()

        {

        }

        public async global::System.Threading.Tasks.Task<global::oneDrive.Iitem> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::oneDrive.IitemFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::oneDrive.Iitem, TTarget>> navigationPropertyAccessor)

        {

            return (global::oneDrive.IitemFetcher) new global::oneDrive.itemFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::oneDrive.Iitem> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::oneDrive.item, global::oneDrive.Iitem>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::oneDrive.Iitem> _query;

    }

    internal partial class itemCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::oneDrive.Iitem>, global::oneDrive.IitemCollection

    {

        internal itemCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::oneDrive.IitemFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::oneDrive.Iitem>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AdditemAsync(global::oneDrive.Iitem item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::oneDrive.IitemFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::oneDrive.item>((i) => i.id == id);

                var fetcher = new global::oneDrive.itemFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class itemCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    internal partial class itemFetcher

    {

    }

    public partial class item

    {

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class permission:Microsoft.OData.ProxyExtensions.EntityBase, global::oneDrive.Ipermission, global::oneDrive.IpermissionFetcher

    {

        private global::oneDrive.identitySet _grantedTo;

        private System.String _id;

        private global::oneDrive.sharingInvitation _invitation;

        private global::oneDrive.itemReference _inheritedFrom;

        private global::oneDrive.sharingLink _link;

        private Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String> _roles;

        public global::oneDrive.identitySet grantedTo

        {

            get

            {

                return _grantedTo;

            }

            set

            {

                if (value != _grantedTo)

                {

                    _grantedTo = value;

                    OnPropertyChanged("grantedTo");

                }

            }

        }

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        public global::oneDrive.sharingInvitation invitation

        {

            get

            {

                return _invitation;

            }

            set

            {

                if (value != _invitation)

                {

                    _invitation = value;

                    OnPropertyChanged("invitation");

                }

            }

        }

        public global::oneDrive.itemReference inheritedFrom

        {

            get

            {

                return _inheritedFrom;

            }

            set

            {

                if (value != _inheritedFrom)

                {

                    _inheritedFrom = value;

                    OnPropertyChanged("inheritedFrom");

                }

            }

        }

        public global::oneDrive.sharingLink link

        {

            get

            {

                return _link;

            }

            set

            {

                if (value != _link)

                {

                    _link = value;

                    OnPropertyChanged("link");

                }

            }

        }

        public System.Collections.Generic.IList<System.String> roles

        {

            get

            {

                if (this._roles == default(System.Collections.Generic.IList<System.String>))

                {

                    this._roles = new Microsoft.OData.ProxyExtensions.NonEntityTypeCollectionImpl<System.String>();

                    this._roles.SetContainer(() => GetContainingEntity("roles"));

                }

                return this._roles;

            }

            set

            {

                roles.Clear();

                if (value != null)

                {

                    foreach (var i in value)

                    {

                        roles.Add(i);

                    }

                }

            }

        }

        public permission(): base()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::oneDrive.Ipermission> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::oneDrive.permission, global::oneDrive.Ipermission>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::oneDrive.Ipermission> _query;

        global::System.Threading.Tasks.Task<global::oneDrive.Ipermission> global::oneDrive.IpermissionFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::oneDrive.Ipermission>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::oneDrive.IpermissionFetcher global::oneDrive.IpermissionFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::oneDrive.Ipermission, TTarget>> navigationPropertyAccessor)

        {

            return (global::oneDrive.IpermissionFetcher) this;

        }

    }

    internal partial class permissionFetcher:Microsoft.OData.ProxyExtensions.RestShallowObjectFetcher, global::oneDrive.IpermissionFetcher

    {

        public permissionFetcher(): base()

        {

        }

        public async global::System.Threading.Tasks.Task<global::oneDrive.Ipermission> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::oneDrive.IpermissionFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::oneDrive.Ipermission, TTarget>> navigationPropertyAccessor)

        {

            return (global::oneDrive.IpermissionFetcher) new global::oneDrive.permissionFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::oneDrive.Ipermission> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::oneDrive.permission, global::oneDrive.Ipermission>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::oneDrive.Ipermission> _query;

    }

    internal partial class permissionCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::oneDrive.Ipermission>, global::oneDrive.IpermissionCollection

    {

        internal permissionCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::oneDrive.IpermissionFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::oneDrive.Ipermission>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddpermissionAsync(global::oneDrive.Ipermission item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::oneDrive.IpermissionFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::oneDrive.permission>((i) => i.id == id);

                var fetcher = new global::oneDrive.permissionFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class permissionCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    internal partial class permissionFetcher

    {

    }

    public partial class permission

    {

    }

    [global::Microsoft.OData.Client.Key("id")]

    public partial class thumbnailSet:Microsoft.OData.ProxyExtensions.EntityBase, global::oneDrive.IthumbnailSet, global::oneDrive.IthumbnailSetFetcher

    {

        private System.String _id;

        private global::oneDrive.thumbnail _large;

        private global::oneDrive.thumbnail _medium;

        private global::oneDrive.thumbnail _small;

        private global::oneDrive.thumbnail _source;

        public System.String id

        {

            get

            {

                return _id;

            }

            set

            {

                if (value != _id)

                {

                    _id = value;

                    OnPropertyChanged("id");

                }

            }

        }

        public global::oneDrive.thumbnail large

        {

            get

            {

                return _large;

            }

            set

            {

                if (value != _large)

                {

                    _large = value;

                    OnPropertyChanged("large");

                }

            }

        }

        public global::oneDrive.thumbnail medium

        {

            get

            {

                return _medium;

            }

            set

            {

                if (value != _medium)

                {

                    _medium = value;

                    OnPropertyChanged("medium");

                }

            }

        }

        public global::oneDrive.thumbnail small

        {

            get

            {

                return _small;

            }

            set

            {

                if (value != _small)

                {

                    _small = value;

                    OnPropertyChanged("small");

                }

            }

        }

        public global::oneDrive.thumbnail source

        {

            get

            {

                return _source;

            }

            set

            {

                if (value != _source)

                {

                    _source = value;

                    OnPropertyChanged("source");

                }

            }

        }

        public thumbnailSet(): base()

        {

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::oneDrive.IthumbnailSet> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::oneDrive.thumbnailSet, global::oneDrive.IthumbnailSet>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::oneDrive.IthumbnailSet> _query;

        global::System.Threading.Tasks.Task<global::oneDrive.IthumbnailSet> global::oneDrive.IthumbnailSetFetcher.ExecuteAsync()

        {

            var tsc = new global::System.Threading.Tasks.TaskCompletionSource<global::oneDrive.IthumbnailSet>();

            tsc.SetResult(this);

            return tsc.Task;

        }

        global::oneDrive.IthumbnailSetFetcher global::oneDrive.IthumbnailSetFetcher.Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::oneDrive.IthumbnailSet, TTarget>> navigationPropertyAccessor)

        {

            return (global::oneDrive.IthumbnailSetFetcher) this;

        }

    }

    internal partial class thumbnailSetFetcher:Microsoft.OData.ProxyExtensions.RestShallowObjectFetcher, global::oneDrive.IthumbnailSetFetcher

    {

        public thumbnailSetFetcher(): base()

        {

        }

        public async global::System.Threading.Tasks.Task<global::oneDrive.IthumbnailSet> ExecuteAsync()

        {

            return await EnsureQuery().ExecuteSingleAsync();

        }

        public global::oneDrive.IthumbnailSetFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::oneDrive.IthumbnailSet, TTarget>> navigationPropertyAccessor)

        {

            return (global::oneDrive.IthumbnailSetFetcher) new global::oneDrive.thumbnailSetFetcher()

            {

                _query = this.EnsureQuery().Expand<TTarget>(navigationPropertyAccessor)

            }

            ;

        }

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::oneDrive.IthumbnailSet> EnsureQuery()

        {

            if (this._query == null)

            {

                this._query = CreateQuery<global::oneDrive.thumbnailSet, global::oneDrive.IthumbnailSet>();

            }

            return this._query;

        }

        

        private Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSet<global::oneDrive.IthumbnailSet> _query;

    }

    internal partial class thumbnailSetCollection:Microsoft.OData.ProxyExtensions.QueryableSet<global::oneDrive.IthumbnailSet>, global::oneDrive.IthumbnailSetCollection

    {

        internal thumbnailSetCollection(global::Microsoft.OData.Client.DataServiceQuery inner,Microsoft.OData.ProxyExtensions.DataServiceContextWrapper context,object entity,string path): base(inner, context, entity as Microsoft.OData.ProxyExtensions.EntityBase, path)

        {

        }

        public global::oneDrive.IthumbnailSetFetcher GetById(System.String id)

        {

            return this[id];

        }

        public global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::oneDrive.IthumbnailSet>> ExecuteAsync()

        {

            return ExecuteAsyncInternal();

        }

        public global::System.Threading.Tasks.Task AddthumbnailSetAsync(global::oneDrive.IthumbnailSet item, System.Boolean deferSaveChanges = false)

        {

            if (Entity == null)

            {

                Context.AddObject(Path, item);

            }

            else

            {

                var lastSlash = Path.LastIndexOf('/');

                var shortPath = (lastSlash >= 0 && lastSlash < Path.Length - 1) ? Path.Substring(lastSlash + 1) : Path;

                Context.AddRelatedObject(Entity, shortPath, item);

            }

            if (!deferSaveChanges)

            {

                return Context.SaveChangesAsync();

            }

            else

            {

                var retVal = new global::System.Threading.Tasks.TaskCompletionSource<object>();

                retVal.SetResult(null);

                return retVal.Task;

            }

        }

        public global::oneDrive.IthumbnailSetFetcher this[System.String id]

        {

            get

            {

                var path = GetPath<global::oneDrive.thumbnailSet>((i) => i.id == id);

                var fetcher = new global::oneDrive.thumbnailSetFetcher();

                fetcher.Initialize(Context, path);

                

                return fetcher;

            }

        }

    }

    internal partial class thumbnailSetCollection

    {

        public global::System.Threading.Tasks.Task<System.Int64> CountAsync()

        {

            return new DataServiceQuerySingle<long>(Context, Path + "/$count").GetValueAsync();

        }

    }

    internal partial class thumbnailSetFetcher

    {

    }

    public partial class thumbnailSet

    {

    }

    public partial class oneDrive:global::oneDrive.IoneDrive

    {

        private const System.String _path = "";

        private global::oneDrive.driveCollection _drivesCollection;

        public global::oneDrive.IdriveCollection drives

        {

            get

            {

                if (this._drivesCollection == null)

                {

                    this._drivesCollection = new global::oneDrive.driveCollection(
                       Context != null ? Context.CreateQuery<global::oneDrive.drive>(GetPath("drives")) : null,
                       Context,
                       this,
                       GetPath("drives"));

                }

                

                return this._drivesCollection;

            }

        }

        public Microsoft.OData.ProxyExtensions.DataServiceContextWrapper Context

        {get; private set;}

        public oneDrive(global::System.Uri serviceRoot, global::System.Func<global::System.Threading.Tasks.Task<string>> accessTokenGetter)

        {

            Context = new Microsoft.OData.ProxyExtensions.DataServiceContextWrapper(serviceRoot, global::Microsoft.OData.Client.ODataProtocolVersion.V4, accessTokenGetter);

            Context.MergeOption = global::Microsoft.OData.Client.MergeOption.OverwriteChanges;

            Context.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);

            Context.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);

            this.OnContextCreated();

            Context.Format.LoadServiceModel = GeneratedEdmModel.GetInstance;

            Context.Format.UseJson();

        }

        partial void OnContextCreated();

        public void AddTodrives(global::oneDrive.Idrive drives)

        {

            this.Context.AddObject("drives", (object) drives);

        }

        private global::System.Type ResolveTypeFromName(System.String typeName)

        {

            global::System.Type resolvedType;

            resolvedType = Context.DefaultResolveTypeInternal(typeName,  "oneDrive", "oneDrive");

            if (resolvedType != null)

            {

                return resolvedType;

            }

            return null;

        }

        private System.String ResolveNameFromType(global::System.Type clientType)

        {

            string resolvedType;

            resolvedType = Context.DefaultResolveNameInternal(clientType,  "oneDrive", "oneDrive");

            if (!string.IsNullOrEmpty(resolvedType))

            {

                return resolvedType;

            }

            return clientType.FullName;

        }

        private System.String GetPath(System.String propertyName)

        {

            return propertyName == null ? _path : _path + "/" + propertyName;

        }

        private System.Uri GetUrl()

        {

            return this.Context.BaseUri;

        }

        private abstract partial class GeneratedEdmModel

        {

            private static global::Microsoft.OData.Edm.IEdmModel ParsedModel = LoadModelFromString();

            private const System.String Edmx = @"<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
            
              <edmx:DataServices>
            
                <Schema Namespace=""oneDrive"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
            
                  <EntityType Name=""drive"">
            
                    <Key>
            
                      <PropertyRef Name=""id"" />
            
                    </Key>
            
                    <Property Name=""id"" Type=""Edm.String"" Nullable=""false"" />
            
                    <Property Name=""driveType"" Type=""Edm.String"" />
            
                    <Property Name=""owner"" Type=""global::oneDrive.identitySet"" />
            
                    <Property Name=""quota"" Type=""global::oneDrive.quota"" />
            
                    <NavigationProperty Name=""items"" Type=""Collection(global::oneDrive.item)"" ContainsTarget=""true"" />
            
                    <NavigationProperty Name=""shared"" Type=""Collection(global::oneDrive.item)"" ContainsTarget=""true"" />
            
                    <NavigationProperty Name=""special"" Type=""Collection(global::oneDrive.item)"" ContainsTarget=""true"" />
            
                  </EntityType>
            
                  <EntityType Name=""item"">
            
                    <Key>
            
                      <PropertyRef Name=""id"" />
            
                    </Key>
            
                    <Property Name=""content"" Type=""Edm.Stream"" />
            
                    <Property Name=""createdBy"" Type=""global::oneDrive.identitySet"" />
            
                    <Property Name=""createdDateTime"" Type=""Edm.DateTimeOffset"" />
            
                    <Property Name=""cTag"" Type=""Edm.String"" />
            
                    <Property Name=""eTag"" Type=""Edm.String"" />
            
                    <Property Name=""id"" Type=""Edm.String"" Nullable=""false"" />
            
                    <Property Name=""lastModifiedBy"" Type=""global::oneDrive.identitySet"" />
            
                    <Property Name=""lastModifiedDateTime"" Type=""Edm.DateTimeOffset"" />
            
                    <Property Name=""name"" Type=""Edm.String"" />
            
                    <Property Name=""parentReference"" Type=""global::oneDrive.itemReference"" />
            
                    <Property Name=""size"" Type=""Edm.Int64"" />
            
                    <Property Name=""webUrl"" Type=""Edm.String"" />
            
                    <Property Name=""audio"" Type=""global::oneDrive.audio"" />
            
                    <Property Name=""deleted"" Type=""global::oneDrive.deleted"" />
            
                    <Property Name=""file"" Type=""global::oneDrive.file"" />
            
                    <Property Name=""folder"" Type=""global::oneDrive.folder"" />
            
                    <Property Name=""image"" Type=""global::oneDrive.image"" />
            
                    <Property Name=""location"" Type=""global::oneDrive.location"" />
            
                    <Property Name=""photo"" Type=""global::oneDrive.photo"" />
            
                    <Property Name=""specialFolder"" Type=""global::oneDrive.specialFolder"" />
            
                    <Property Name=""video"" Type=""global::oneDrive.video"" />
            
                    <NavigationProperty Name=""children"" Type=""Collection(global::oneDrive.item)"" ContainsTarget=""true"" />
            
                    <NavigationProperty Name=""permissions"" Type=""Collection(global::oneDrive.permission)"" ContainsTarget=""true"" />
            
                    <NavigationProperty Name=""thumbnails"" Type=""Collection(global::oneDrive.thumbnailSet)"" ContainsTarget=""true"" />
            
                  </EntityType>
            
                  <ComplexType Name=""itemReference"">
            
                    <Property Name=""driveId"" Type=""Edm.String"" />
            
                    <Property Name=""id"" Type=""Edm.String"" />
            
                    <Property Name=""path"" Type=""Edm.String"" />
            
                  </ComplexType>
            
                  <ComplexType Name=""uploadSession"">
            
                    <Property Name=""uploadUrl"" Type=""Edm.String"" />
            
                    <Property Name=""expirationDateTime"" Type=""Edm.DateTimeOffset"" />
            
                    <Property Name=""nextExpectedRanges"" Type=""Collection(Edm.String)"" />
            
                  </ComplexType>
            
                  <ComplexType Name=""chunkedUploadSessionDescriptor"">
            
                    <Property Name=""name"" Type=""Edm.String"" />
            
                    <Property Name=""size"" Type=""Edm.Int64"" />
            
                  </ComplexType>
            
                  <ComplexType Name=""audio"">
            
                    <Property Name=""album"" Type=""Edm.String"" />
            
                    <Property Name=""albumArtist"" Type=""Edm.String"" />
            
                    <Property Name=""artist"" Type=""Edm.String"" />
            
                    <Property Name=""bitrate"" Type=""Edm.Int64"" />
            
                    <Property Name=""composers"" Type=""Edm.String"" />
            
                    <Property Name=""copyright"" Type=""Edm.String"" />
            
                    <Property Name=""disc"" Type=""Edm.Int32"" />
            
                    <Property Name=""discCount"" Type=""Edm.Int32"" />
            
                    <Property Name=""duration"" Type=""Edm.Int64"" />
            
                    <Property Name=""genre"" Type=""Edm.String"" />
            
                    <Property Name=""hasDrm"" Type=""Edm.Boolean"" />
            
                    <Property Name=""isVariableBitrate"" Type=""Edm.Boolean"" />
            
                    <Property Name=""title"" Type=""Edm.String"" />
            
                    <Property Name=""track"" Type=""Edm.Int64"" />
            
                    <Property Name=""trackCount"" Type=""Edm.Int64"" />
            
                    <Property Name=""year"" Type=""Edm.Int64"" />
            
                  </ComplexType>
            
                  <ComplexType Name=""deleted"">
            
                    <Property Name=""state"" Type=""Edm.String"" />
            
                  </ComplexType>
            
                  <ComplexType Name=""file"">
            
                    <Property Name=""hashes"" Type=""global::oneDrive.hashes"" />
            
                    <Property Name=""mimeType"" Type=""Edm.String"" />
            
                  </ComplexType>
            
                  <ComplexType Name=""folder"">
            
                    <Property Name=""childCount"" Type=""Edm.Int32"" />
            
                  </ComplexType>
            
                  <ComplexType Name=""hashes"">
            
                    <Property Name=""crc32Hash"" Type=""Edm.String"" />
            
                    <Property Name=""sha1Hash"" Type=""Edm.String"" />
            
                  </ComplexType>
            
                  <ComplexType Name=""image"">
            
                    <Property Name=""height"" Type=""Edm.Int32"" />
            
                    <Property Name=""width"" Type=""Edm.Int32"" />
            
                  </ComplexType>
            
                  <ComplexType Name=""location"">
            
                    <Property Name=""altitude"" Type=""Edm.Double"" />
            
                    <Property Name=""latitude"" Type=""Edm.Double"" />
            
                    <Property Name=""longitude"" Type=""Edm.Double"" />
            
                  </ComplexType>
            
                  <EntityType Name=""permission"">
            
                    <Key>
            
                      <PropertyRef Name=""id"" />
            
                    </Key>
            
                    <Property Name=""grantedTo"" Type=""global::oneDrive.identitySet"" />
            
                    <Property Name=""id"" Type=""Edm.String"" Nullable=""false"" />
            
                    <Property Name=""invitation"" Type=""global::oneDrive.sharingInvitation"" />
            
                    <Property Name=""inheritedFrom"" Type=""global::oneDrive.itemReference"" />
            
                    <Property Name=""link"" Type=""global::oneDrive.sharingLink"" />
            
                    <Property Name=""roles"" Type=""Collection(Edm.String)"" />
            
                  </EntityType>
            
                  <ComplexType Name=""photo"">
            
                    <Property Name=""cameraMake"" Type=""Edm.String"" />
            
                    <Property Name=""cameraModel"" Type=""Edm.String"" />
            
                    <Property Name=""exposureDenominator"" Type=""Edm.Double"" />
            
                    <Property Name=""exposureNumerator"" Type=""Edm.Double"" />
            
                    <Property Name=""focalLength"" Type=""Edm.Double"" />
            
                    <Property Name=""fNumber"" Type=""Edm.Double"" />
            
                    <Property Name=""takenDateTime"" Type=""Edm.DateTimeOffset"" />
            
                  </ComplexType>
            
                  <ComplexType Name=""quota"">
            
                    <Property Name=""deleted"" Type=""Edm.Int64"" />
            
                    <Property Name=""remaining"" Type=""Edm.Int64"" />
            
                    <Property Name=""state"" Type=""Edm.String"" />
            
                    <Property Name=""total"" Type=""Edm.Int64"" />
            
                    <Property Name=""used"" Type=""Edm.Int64"" />
            
                  </ComplexType>
            
                  <ComplexType Name=""sharingInvitation"">
            
                    <Property Name=""email"" Type=""Edm.String"" />
            
                    <Property Name=""redeemedBy"" Type=""Edm.String"" />
            
                    <Property Name=""signInRequired"" Type=""Edm.Boolean"" />
            
                  </ComplexType>
            
                  <ComplexType Name=""sharingLink"">
            
                    <Property Name=""application"" Type=""global::oneDrive.identity"" />
            
                    <Property Name=""token"" Type=""Edm.String"" />
            
                    <Property Name=""type"" Type=""Edm.String"" />
            
                    <Property Name=""webUrl"" Type=""Edm.String"" />
            
                  </ComplexType>
            
                  <ComplexType Name=""specialFolder"">
            
                    <Property Name=""name"" Type=""Edm.String"" />
            
                  </ComplexType>
            
                  <ComplexType Name=""video"">
            
                    <Property Name=""bitrate"" Type=""Edm.Int64"" />
            
                    <Property Name=""duration"" Type=""Edm.Int64"" />
            
                    <Property Name=""height"" Type=""Edm.Int64"" />
            
                    <Property Name=""width"" Type=""Edm.Int64"" />
            
                  </ComplexType>
            
                  <ComplexType Name=""identitySet"" OpenType=""true"">
            
                    <Property Name=""application"" Type=""global::oneDrive.identity"" />
            
                    <Property Name=""device"" Type=""global::oneDrive.identity"" />
            
                    <Property Name=""user"" Type=""global::oneDrive.identity"" />
            
                  </ComplexType>
            
                  <ComplexType Name=""identity"">
            
                    <Property Name=""displayName"" Type=""Edm.String"" />
            
                    <Property Name=""id"" Type=""Edm.String"" />
            
                  </ComplexType>
            
                  <EntityType Name=""thumbnailSet"" OpenType=""true"">
            
                    <Key>
            
                      <PropertyRef Name=""id"" />
            
                    </Key>
            
                    <Property Name=""id"" Type=""Edm.String"" Nullable=""false"" />
            
                    <Property Name=""large"" Type=""global::oneDrive.thumbnail"" />
            
                    <Property Name=""medium"" Type=""global::oneDrive.thumbnail"" />
            
                    <Property Name=""small"" Type=""global::oneDrive.thumbnail"" />
            
                    <Property Name=""source"" Type=""global::oneDrive.thumbnail"" />
            
                  </EntityType>
            
                  <ComplexType Name=""thumbnail"">
            
                    <Property Name=""content"" Type=""Edm.Stream"" />
            
                    <Property Name=""height"" Type=""Edm.Int32"" />
            
                    <Property Name=""url"" Type=""Edm.String"" />
            
                    <Property Name=""width"" Type=""Edm.Int32"" />
            
                  </ComplexType>
            
                  <EntityContainer Name=""oneDrive"">
            
                    <EntitySet Name=""drives"" EntityType=""global::oneDrive.drive"" />
            
                  </EntityContainer>
            
                </Schema>
            
                <Schema Namespace=""view"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
            
                  <Function Name=""allPhotos"" IsBound=""true"">
            
                    <Parameter Name=""bindingParameter"" Type=""global::oneDrive.drive"" Nullable=""false"" />
            
                    <ReturnType Type=""Collection(global::oneDrive.item)"" Nullable=""false"" />
            
                  </Function>
            
                  <Function Name=""allPhotos"" IsBound=""true"">
            
                    <Parameter Name=""bindingParameter"" Type=""global::oneDrive.item"" Nullable=""false"" />
            
                    <ReturnType Type=""Collection(global::oneDrive.item)"" Nullable=""false"" />
            
                  </Function>
            
                  <Function Name=""changes"" IsBound=""true"">
            
                    <Parameter Name=""bindingParameter"" Type=""global::oneDrive.item"" Nullable=""false"" />
            
                    <ReturnType Type=""Collection(global::oneDrive.item)"" Nullable=""false"" />
            
                  </Function>
            
                  <Function Name=""changes"" IsBound=""true"">
            
                    <Parameter Name=""bindingParameter"" Type=""global::oneDrive.drive"" Nullable=""false"" />
            
                    <ReturnType Type=""Collection(global::oneDrive.item)"" Nullable=""false"" />
            
                  </Function>
            
                  <Function Name=""recent"" IsBound=""true"">
            
                    <Parameter Name=""bindingParameter"" Type=""global::oneDrive.drive"" Nullable=""false"" />
            
                    <ReturnType Type=""Collection(global::oneDrive.item)"" Nullable=""false"" />
            
                  </Function>
            
                  <Function Name=""search"" IsBound=""true"">
            
                    <Parameter Name=""bindingParameter"" Type=""global::oneDrive.item"" Nullable=""false"" />
            
                    <ReturnType Type=""Collection(global::oneDrive.item)"" Nullable=""false"" />
            
                  </Function>
            
                  <Function Name=""sharedWithMe"" IsBound=""true"">
            
                    <Parameter Name=""bindingParameter"" Type=""global::oneDrive.drive"" Nullable=""false"" />
            
                    <ReturnType Type=""Collection(global::oneDrive.item)"" Nullable=""false"" />
            
                  </Function>
            
                </Schema>
            
                <Schema Namespace=""upload"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
            
                  <Action Name=""createSession"" IsBound=""true"">
            
                    <Parameter Name=""bindingParameter"" Type=""global::oneDrive.item"" Nullable=""false"" />
            
                    <Parameter Name=""item"" Type=""global::oneDrive.chunkedUploadSessionDescriptor"" />
            
                    <ReturnType Type=""global::oneDrive.uploadSession"" Nullable=""false"" />
            
                  </Action>
            
                </Schema>
            
                <Schema Namespace=""action"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
            
                  <Action Name=""copy"" IsBound=""true"">
            
                    <Parameter Name=""bindingParameter"" Type=""global::oneDrive.item"" Nullable=""false"" />
            
                    <Parameter Name=""parentReference"" Type=""global::oneDrive.itemReference"" />
            
                    <Parameter Name=""name"" Type=""Edm.String"" />
            
                    <ReturnType Type=""global::oneDrive.item"" Nullable=""false"" />
            
                  </Action>
            
                  <Action Name=""createLink"" IsBound=""true"">
            
                    <Parameter Name=""bindingParameter"" Type=""global::oneDrive.item"" Nullable=""false"" />
            
                    <Parameter Name=""type"" Type=""Edm.String"" Nullable=""false"" />
            
                    <ReturnType Type=""global::oneDrive.permission"" Nullable=""false"" />
            
                  </Action>
            
                </Schema>
            
                <Schema Namespace=""content"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
            
                  <Term Name=""sourceUrl"" Type=""Edm.String"" AppliesTo=""global::oneDrive.item"">
            
                    <Annotation Term=""Org.OData.Core.V1.LongDescription"" String=""When used on a PUT or POST call to an Item, causes the item's content to be copied from the URL specified in the attribute."" />
            
                  </Term>
            
                  <Term Name=""downloadUrl"" Type=""Edm.String"" AppliesTo=""global::oneDrive.item"">
            
                    <Annotation Term=""Org.OData.Core.V1.LongDescription"" String=""Returned with an Item that contains content to provide a URL for directly accessing said content."" />
            
                  </Term>
            
                </Schema>
            
                <Schema Namespace=""name"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
            
                  <Term Name=""conflictBehavior"" Type=""Edm.String"" AppliesTo=""global::oneDrive.item"">
            
                    <Annotation Term=""Org.OData.Core.V1.LongDescription"" String=""When used on a PUT or POST call that sets metadata and content, specifies what to do if an existing file with the same name already exists. Possible values are 'fail' (default), 'replace', or 'rename'."" />
            
                  </Term>
            
                </Schema>
            
                <Schema Namespace=""changes"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
            
                  <Term Name=""token"" Type=""Edm.String"" AppliesTo=""view.changes"">
            
                    <Annotation Term=""Org.OData.Core.V1.LongDescription"" String=""Returned with a view.changes feed to provide the sync token for subsequent change requests."" />
            
                  </Term>
            
                  <Term Name=""hasMoreChanges"" Type=""Edm.Boolean"" AppliesTo=""view.changes"">
            
                    <Annotation Term=""Org.OData.Core.V1.LongDescription"" String=""Returned with a view.changes feed to indicate whether there are additional changes immediately available to sync with the next link."" />
            
                  </Term>
            
                  <Term Name=""resync"" Type=""Edm.String"" AppliesTo=""view.changes"">
            
                    <Annotation Term=""Org.OData.Core.V1.LongDescription"" String=""Returned with a view.changes feed when the client must perform a full resync of any cached sync state."" />
            
                  </Term>
            
                </Schema>
            
              </edmx:DataServices>
            
            </edmx:Edmx>";

            public static global::Microsoft.OData.Edm.IEdmModel GetInstance()

            {

                return ParsedModel;

            }

            private static global::Microsoft.OData.Edm.IEdmModel LoadModelFromString()

            {

                global::System.Xml.XmlReader reader = CreateXmlReader(Edmx);

                try

                {

                    return global::Microsoft.OData.Edm.Csdl.EdmxReader.Parse(reader);

                }

                finally

                {

                    ((global::System.IDisposable)(reader)).Dispose();

                }

            }

            private static global::System.Xml.XmlReader CreateXmlReader(System.String edmxToParse)

            {

                return global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(edmxToParse));

            }

        }

    }

    [Microsoft.OData.ProxyExtensions.LowerCaseProperty]

    public partial interface Idrive:Microsoft.OData.ProxyExtensions.IEntityBase

    {

        System.String id
        {get;set;}

        System.String driveType
        {get;set;}

        global::oneDrive.identitySet owner
        {get;set;}

        global::oneDrive.quota quota
        {get;set;}

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::oneDrive.Iitem> items
        {get;}

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::oneDrive.Iitem> shared
        {get;}

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::oneDrive.Iitem> special
        {get;}

    }

    [Microsoft.OData.ProxyExtensions.LowerCaseProperty]

    public partial interface IdriveFetcher

    {

        global::oneDrive.IitemCollection items
        {get;}

        global::oneDrive.IitemCollection shared
        {get;}

        global::oneDrive.IitemCollection special
        {get;}

        global::System.Threading.Tasks.Task<global::oneDrive.Idrive> ExecuteAsync();

        global::oneDrive.IdriveFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::oneDrive.Idrive, TTarget>> navigationPropertyAccessor);

    }

    [Microsoft.OData.ProxyExtensions.LowerCaseProperty]

    public partial interface IdriveCollection:Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSetBase<global::oneDrive.Idrive>

    {

        global::oneDrive.IdriveFetcher GetById(System.String id);

        global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::oneDrive.Idrive>> ExecuteAsync();

        global::System.Threading.Tasks.Task AdddriveAsync(global::oneDrive.Idrive item, System.Boolean deferSaveChanges = false);

         global::oneDrive.IdriveFetcher this[System.String id]

        {get;}

    }

    public partial interface IdriveCollection

    {

        global::System.Threading.Tasks.Task<System.Int64> CountAsync();

    }

    public partial interface IdriveFetcher

    {

    }

    [Microsoft.OData.ProxyExtensions.LowerCaseProperty]

    public partial interface Iitem:Microsoft.OData.ProxyExtensions.IEntityBase

    {

        Microsoft.OData.Client.DataServiceStreamLink content
        {get;set;}

        global::oneDrive.identitySet createdBy
        {get;set;}

        System.Nullable<System.DateTimeOffset> createdDateTime
        {get;set;}

        System.String cTag
        {get;set;}

        System.String eTag
        {get;set;}

        System.String id
        {get;set;}

        global::oneDrive.identitySet lastModifiedBy
        {get;set;}

        System.Nullable<System.DateTimeOffset> lastModifiedDateTime
        {get;set;}

        System.String name
        {get;set;}

        global::oneDrive.itemReference parentReference
        {get;set;}

        System.Nullable<System.Int64> size
        {get;set;}

        System.String webUrl
        {get;set;}

        global::oneDrive.audio audio
        {get;set;}

        global::oneDrive.deleted deleted
        {get;set;}

        global::oneDrive.file file
        {get;set;}

        global::oneDrive.folder folder
        {get;set;}

        global::oneDrive.image image
        {get;set;}

        global::oneDrive.location location
        {get;set;}

        global::oneDrive.photo photo
        {get;set;}

        global::oneDrive.specialFolder specialFolder
        {get;set;}

        global::oneDrive.video video
        {get;set;}

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::oneDrive.Iitem> children
        {get;}

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::oneDrive.Ipermission> permissions
        {get;}

        Microsoft.OData.ProxyExtensions.IPagedCollection<global::oneDrive.IthumbnailSet> thumbnails
        {get;}

    }

    [Microsoft.OData.ProxyExtensions.LowerCaseProperty]

    public partial interface IitemFetcher

    {

        global::oneDrive.IitemCollection children
        {get;}

        global::oneDrive.IpermissionCollection permissions
        {get;}

        global::oneDrive.IthumbnailSetCollection thumbnails
        {get;}

        global::System.Threading.Tasks.Task<global::oneDrive.Iitem> ExecuteAsync();

        global::oneDrive.IitemFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::oneDrive.Iitem, TTarget>> navigationPropertyAccessor);

    }

    [Microsoft.OData.ProxyExtensions.LowerCaseProperty]

    public partial interface IitemCollection:Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSetBase<global::oneDrive.Iitem>

    {

        global::oneDrive.IitemFetcher GetById(System.String id);

        global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::oneDrive.Iitem>> ExecuteAsync();

        global::System.Threading.Tasks.Task AdditemAsync(global::oneDrive.Iitem item, System.Boolean deferSaveChanges = false);

         global::oneDrive.IitemFetcher this[System.String id]

        {get;}

    }

    public partial interface IitemCollection

    {

        global::System.Threading.Tasks.Task<System.Int64> CountAsync();

    }

    public partial interface IitemFetcher

    {

    }

    [Microsoft.OData.ProxyExtensions.LowerCaseProperty]

    public partial interface Ipermission:Microsoft.OData.ProxyExtensions.IEntityBase

    {

        global::oneDrive.identitySet grantedTo
        {get;set;}

        System.String id
        {get;set;}

        global::oneDrive.sharingInvitation invitation
        {get;set;}

        global::oneDrive.itemReference inheritedFrom
        {get;set;}

        global::oneDrive.sharingLink link
        {get;set;}

        System.Collections.Generic.IList<System.String> roles
        {get;set;}

    }

    [Microsoft.OData.ProxyExtensions.LowerCaseProperty]

    public partial interface IpermissionFetcher

    {

        global::System.Threading.Tasks.Task<global::oneDrive.Ipermission> ExecuteAsync();

        global::oneDrive.IpermissionFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::oneDrive.Ipermission, TTarget>> navigationPropertyAccessor);

    }

    [Microsoft.OData.ProxyExtensions.LowerCaseProperty]

    public partial interface IpermissionCollection:Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSetBase<global::oneDrive.Ipermission>

    {

        global::oneDrive.IpermissionFetcher GetById(System.String id);

        global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::oneDrive.Ipermission>> ExecuteAsync();

        global::System.Threading.Tasks.Task AddpermissionAsync(global::oneDrive.Ipermission item, System.Boolean deferSaveChanges = false);

         global::oneDrive.IpermissionFetcher this[System.String id]

        {get;}

    }

    public partial interface IpermissionCollection

    {

        global::System.Threading.Tasks.Task<System.Int64> CountAsync();

    }

    public partial interface IpermissionFetcher

    {

    }

    [Microsoft.OData.ProxyExtensions.LowerCaseProperty]

    public partial interface IthumbnailSet:Microsoft.OData.ProxyExtensions.IEntityBase

    {

        System.String id
        {get;set;}

        global::oneDrive.thumbnail large
        {get;set;}

        global::oneDrive.thumbnail medium
        {get;set;}

        global::oneDrive.thumbnail small
        {get;set;}

        global::oneDrive.thumbnail source
        {get;set;}

    }

    [Microsoft.OData.ProxyExtensions.LowerCaseProperty]

    public partial interface IthumbnailSetFetcher

    {

        global::System.Threading.Tasks.Task<global::oneDrive.IthumbnailSet> ExecuteAsync();

        global::oneDrive.IthumbnailSetFetcher Expand<TTarget>(System.Linq.Expressions.Expression<System.Func<global::oneDrive.IthumbnailSet, TTarget>> navigationPropertyAccessor);

    }

    [Microsoft.OData.ProxyExtensions.LowerCaseProperty]

    public partial interface IthumbnailSetCollection:Microsoft.OData.ProxyExtensions.IReadOnlyQueryableSetBase<global::oneDrive.IthumbnailSet>

    {

        global::oneDrive.IthumbnailSetFetcher GetById(System.String id);

        global::System.Threading.Tasks.Task<Microsoft.OData.ProxyExtensions.IPagedCollection<global::oneDrive.IthumbnailSet>> ExecuteAsync();

        global::System.Threading.Tasks.Task AddthumbnailSetAsync(global::oneDrive.IthumbnailSet item, System.Boolean deferSaveChanges = false);

         global::oneDrive.IthumbnailSetFetcher this[System.String id]

        {get;}

    }

    public partial interface IthumbnailSetCollection

    {

        global::System.Threading.Tasks.Task<System.Int64> CountAsync();

    }

    public partial interface IthumbnailSetFetcher

    {

    }

    public partial interface IoneDrive

    {

        global::oneDrive.IdriveCollection drives
        {get;}

    }

}

namespace view

{

    using global::Microsoft.OData.Client;

    using global::Microsoft.OData.Edm;

    using System;

    using System.Collections.Generic;

    using System.ComponentModel;

    using System.Linq;

    using System.Reflection;

    using System.Threading.Tasks;

}

namespace upload

{

    using global::Microsoft.OData.Client;

    using global::Microsoft.OData.Edm;

    using System;

    using System.Collections.Generic;

    using System.ComponentModel;

    using System.Linq;

    using System.Reflection;

    using System.Threading.Tasks;

}

namespace action

{

    using global::Microsoft.OData.Client;

    using global::Microsoft.OData.Edm;

    using System;

    using System.Collections.Generic;

    using System.ComponentModel;

    using System.Linq;

    using System.Reflection;

    using System.Threading.Tasks;

}

namespace content

{

    using global::Microsoft.OData.Client;

    using global::Microsoft.OData.Edm;

    using System;

    using System.Collections.Generic;

    using System.ComponentModel;

    using System.Linq;

    using System.Reflection;

    using System.Threading.Tasks;

}

namespace name

{

    using global::Microsoft.OData.Client;

    using global::Microsoft.OData.Edm;

    using System;

    using System.Collections.Generic;

    using System.ComponentModel;

    using System.Linq;

    using System.Reflection;

    using System.Threading.Tasks;

}

namespace changes

{

    using global::Microsoft.OData.Client;

    using global::Microsoft.OData.Edm;

    using System;

    using System.Collections.Generic;

    using System.ComponentModel;

    using System.Linq;

    using System.Reflection;

    using System.Threading.Tasks;

}


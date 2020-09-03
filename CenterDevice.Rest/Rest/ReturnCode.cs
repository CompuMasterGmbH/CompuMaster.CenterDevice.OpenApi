﻿
namespace CenterDevice.Rest
{
    public enum ReturnCode : int
    {
        MISSING_OR_MALFORMED_HTTP_HEADER = 100,
        MISSING_BODY_PART = 101,
        MISSING_REQUEST_DATA = 102,
        INVALID_REQUEST_DATA = 103,
        UNKNOWN_ACTION = 104,
        UNSUPPORTED_MIMETYPE = 105,
        UNSUPPORTED_ENCODING = 106,
        UPLOAD_SIZE_EXCEEDED = 107,
        BAD_UPLOAD_SIZE = 108,
        INSUFFICIENT_PRIVILEGES = 200,
        DOCUMENT_LOCKED = 201,
        UNSUPPORTED_FOR_DISTRIBUTOR = 202,
        INVALID_STATE = 300,
        INVALID_PARAMETER_COMBINATION = 301,
        DOCUMENT_ALREADY_LINKED = 302,
        GROUP_NAME_ALREADY_EXISTS = 303,
        EMAIL_RESTRICTION_VIOLATED = 304,
        USER_ALREADY_REGISTERED = 305,
        COLLECTION_ALREADY_LINKED = 306,
        NOT_ENABLED = 400,
        NUMBER_OF_DOCUMENTS_LIMIT_EXCEEDED = 401,
        NUMBER_OF_DOWNLOADS_LIMIT_EXCEEDED = 402,
        DOWNLOAD_VOLUME_LIMIT_EXCEEDED = 403,
        USED_BYTES_LIMIT_EXCEEDED = 404,
        DOCUMENT_ARCHIVED = 308,
        COLLECTION_ARCHIVED = 309,
        INTERNAL_PLACEHOLDER = 9998,
        INTERNAL_SERVER_ERROR = 9999
    }
}
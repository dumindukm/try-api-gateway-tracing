# OpenTelemetry packages App gateway


dotnet add Web.BaseApiGateway package OpenTelemetry.Instrumentation.AspNetCore --prerelease
dotnet add Web.BaseApiGateway package OpenTelemetry.Extensions.Hosting --prerelease
dotnet add Web.BaseApiGateway package OpenTelemetry.Exporter.Console --prerelease
dotnet add Web.BaseApiGateway package OpenTelemetry.Instrumentation.Http --prerelease
dotnet add Web.BaseApiGateway package OpenTelemetry.Exporter.Jaeger --prerelease
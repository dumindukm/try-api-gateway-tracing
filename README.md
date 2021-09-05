# OpenTelemetry packages App gateway


dotnet add Web.BaseApiGateway package OpenTelemetry.Instrumentation.AspNetCore --prerelease
dotnet add Web.BaseApiGateway package OpenTelemetry.Extensions.Hosting --prerelease
dotnet add Web.BaseApiGateway package OpenTelemetry.Exporter.Console --prerelease
dotnet add Web.BaseApiGateway package OpenTelemetry.Instrumentation.Http --prerelease
dotnet add Web.BaseApiGateway package OpenTelemetry.Exporter.Jaeger --prerelease

# OpenTelemetry packages products api


dotnet add ProductsApi package OpenTelemetry.Instrumentation.AspNetCore --prerelease
dotnet add ProductsApi package OpenTelemetry.Extensions.Hosting --prerelease
dotnet add ProductsApi package OpenTelemetry.Exporter.Console --prerelease
dotnet add ProductsApi package OpenTelemetry.Instrumentation.Http --prerelease
dotnet add ProductsApi package OpenTelemetry.Exporter.Jaeger --prerelease


docker run -d --name jaeger -e COLLECTOR_ZIPKIN_HOST_PORT=:9411 -p 5775:5775/udp -p 6831:6831/udp -p 6832:6832/udp -p 5778:5778 -p 16686:16686 -p 14268:14268 -p 14250:14250 -p 9411:9411 jaegertracing/all-in-one:latest

http://localhost:16686/ for Jaegar UI
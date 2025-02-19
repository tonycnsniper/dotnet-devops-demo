import { Threater } from "../types/threater";

export default function EventCard({ name, location }: Threater) {
  return (
    <div className="max-w-sm rounded overflow-hidden shadow-lg hover:bg-cyan-600">
      <div className="px-6 py-4">
        <div className="font-bold text-xl mb-2">{name}</div>
        <p className="text-gray-700 text-base">{location}</p>
      </div>
    </div>
  );
}
